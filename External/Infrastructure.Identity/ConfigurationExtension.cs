using Application.Services;
using Application.Settings;
using Application.Wrappers;
using Infrastructure.Identity.Models;
using Infrastructure.Identity.Persistence;
using Infrastructure.Identity.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.Text;

namespace Infrastructure.Identity;

public static class ConfigurationExtension
{
    public static void AddIdentityInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<IdentityContext>(options =>
                   options.UseNpgsql(
                       configuration.GetConnectionString("IdentityConnection"),
                       b => b.MigrationsAssembly(typeof(IdentityContext).Assembly.FullName)));

        services.AddIdentity<ApplicationUser, IdentityRole>(opt =>
        {
            opt.SignIn.RequireConfirmedAccount = false;
            opt.SignIn.RequireConfirmedEmail = false;
            opt.SignIn.RequireConfirmedPhoneNumber = false;
        })
        .AddEntityFrameworkStores<IdentityContext>()
        .AddDefaultTokenProviders();

        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));

        services.AddScoped<IAccountService, AccountService>();
        services.AddTransient<IAuthenticatedUserService, AuthenticatedUserService>();
        services.AddTransient<IJwtTokenGenerator, JwtTokenGenerator>();

        services.AddAuthorization(options =>
        {
            options.AddPolicy("User", new AuthorizationPolicyBuilder()
                .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
                .RequireAuthenticatedUser()
                .Build());

            options.AddPolicy("Admin", new AuthorizationPolicyBuilder()
                .RequireRole("Admin")
                .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
                .RequireAuthenticatedUser()
                .Build());
        });

        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
        })
        .AddJwtBearer(o =>
        {
            o.RequireHttpsMetadata = false;
            o.SaveToken = true;
            o.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero,
                ValidIssuer = configuration[$"{JwtSettings.SectionName}:Issuer"],
                ValidAudience = configuration[$"{JwtSettings.SectionName}:Audience"],
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration[$"{JwtSettings.SectionName}:Key"]))
            };
            o.Events = new JwtBearerEvents()
            {
                OnMessageReceived = context =>
                {
                    return Task.CompletedTask;
                },
                OnAuthenticationFailed = c =>
                {
                    c.Response.OnStarting(async () =>
                    {
                        c.NoResult();
                        c.Response.StatusCode = StatusCodes.Status401Unauthorized;
                        c.Response.ContentType = "application/json";

                        var result = JsonConvert.SerializeObject(Result<string>.Failure("Предоставленный токен доступа недействителен."));

                        if (c.Exception.GetType() == typeof(SecurityTokenExpiredException))
                        {
                            c.Response.Headers.Add("Token-Expired", "true");
                            result = JsonConvert.SerializeObject(Result<string>.Failure("Срок действия предоставленного токена доступа истек."));
                        }

                        await c.Response.WriteAsync(result);
                    });

                    return Task.CompletedTask;
                },
                OnChallenge = context =>
                {
                    context.HandleResponse();
                    context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                    context.Response.ContentType = "application/json";
                    var result = JsonConvert.SerializeObject(Result<string>.Failure("Вы не авторизованы"));

                    return context.Response.WriteAsync(result);
                },
                OnForbidden = context =>
                {
                    context.Response.StatusCode = StatusCodes.Status403Forbidden;
                    context.Response.ContentType = "application/json";
                    var result = JsonConvert.SerializeObject(Result<string>.Failure("У вас нет прав доступа к этому ресурсу"));

                    return context.Response.WriteAsync(result);
                },
                OnTokenValidated = _ => Task.CompletedTask
            };
        });
    }
}