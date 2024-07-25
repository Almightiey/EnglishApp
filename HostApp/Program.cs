using Application;
using HostApp.Configurations;
using HostApp.Middleware;
using HostApp.Seeder;
using Infrastructure;
using Infrastructure.Identity;
using Presentation;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplication(builder.Configuration);
builder.Services.AddPresentation(builder.Configuration);
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddIdentityInfrastructure(builder.Configuration);
builder.Services.AddCommon(builder.Configuration);

builder.Services.AddControllers()
        .AddApplicationPart(typeof(Presentation.AssemblyReference).Assembly)
        .AddControllersAsServices();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    await Seeder.Start(scope.ServiceProvider);
}

app.UseMiddleware<ErrorHandlingMiddleware>();
app.UseCors("CORS_Policy");
app.UseHttpsRedirection();
app.UseForwardedHeaders();
app.UseSwagger();
app.UseSwaggerUI();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();