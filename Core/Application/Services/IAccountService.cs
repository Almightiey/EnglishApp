using Application.Handlers.User;
using Application.Wrappers;

namespace Application.Services;

public interface IAccountService
{
    Task<UserDto?> GetCurrentUser();
    Task<Result<LoginResponse>> LoginAsync(LoginRequest request);
    Task<Result<string>> RegisterAsync(RegisterRequest request);
}