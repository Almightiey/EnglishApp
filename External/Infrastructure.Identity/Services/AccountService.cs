using Application.Handlers.User;
using Application.Services;
using Application.Wrappers;
using Domain.Common;
using Infrastructure.Identity.Models;
using Microsoft.AspNetCore.Identity;
using System.Data;
using System.Security.Claims;

namespace Infrastructure.Identity.Services;

public class AccountService : IAccountService
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly IAuthenticatedUserService _authenticatedUserService;
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AccountService(
        UserManager<ApplicationUser> userManager,
        RoleManager<IdentityRole> roleManager,
        SignInManager<ApplicationUser> signInManager,
        IAuthenticatedUserService authenticatedUserService,
        IJwtTokenGenerator jwtTokenGenerator)
    {
        _userManager = userManager;
        _roleManager = roleManager;
        _signInManager = signInManager;
        _authenticatedUserService = authenticatedUserService;
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public async Task<UserDto?> GetCurrentUser()
    {
        var user = await _userManager.FindByIdAsync(_authenticatedUserService.UserId);
        var usersRole = await _userManager.GetRolesAsync(user);

        var userDto = new UserDto()
        {
            Id = user.Id,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Role = usersRole.FirstOrDefault()
        };

        return userDto != null ? userDto : null;
    }

    public async Task<Result<LoginResponse>> LoginAsync(LoginRequest request)
    {
        var user = await _userManager.FindByEmailAsync(request.Email);

        if (user == null) return Result<LoginResponse>.Failure("Неправильно введена почта или пароль.");
        if (user.IsDeleted) return Result<LoginResponse>.Failure("Аккаунт с такой почтой был удален.");

        var result = await _signInManager.PasswordSignInAsync(user.UserName!, request.Password, false, lockoutOnFailure: false);
        
        if (!result.Succeeded) return Result<LoginResponse>.Failure("Неправильно введена почта или пароль.");

        LoginResponse response = new()
        {
            Id = user.Id,
            Email = user.Email!,
            UserName = user.UserName!,
        };

        var rolesList = await _userManager.GetRolesAsync(user).ConfigureAwait(false);

        var roleClaims = rolesList.Select(x => new Claim("role", x)).ToList();

        response.Token = _jwtTokenGenerator.GenerateToken(user, roleClaims);
        response.Roles = rolesList.ToList();

        return Result<LoginResponse>.Success(response, $"Authenticated {user.UserName}");
    }

    public async Task<Result<string>> RegisterAsync(RegisterRequest request)
    {
        var userWithSameUserName = await _userManager.FindByNameAsync(request.UserName);

        if (userWithSameUserName is not null && !userWithSameUserName.IsDeleted)
            return Result<string>.Failure("Пользователь с таким логином уже существует");

        var userWithSameEmail = await _userManager.FindByEmailAsync(request.Email);

        if (userWithSameEmail == null)
        {
            var user = new ApplicationUser
            {
                Email = request.Email,
                IsDeleted = false,
                FirstName = "FirstName",
                LastName = "LastName",
                UserName = request.UserName,
            };

            var result = await _userManager.CreateAsync(user, request.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, Roles.User.ToString());
                return Result<string>.Success(user.Id);
            }

            return Result<string>.Failure(string.Join(" ", result.Errors.Select(x => x.Description).ToList()));
        }

        return Result<string>.Failure("Пользователь с такой почтой уже существует");
    }
}
