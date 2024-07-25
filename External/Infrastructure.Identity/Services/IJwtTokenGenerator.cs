using Infrastructure.Identity.Models;
using System.Security.Claims;

namespace Infrastructure.Identity.Services;

public interface IJwtTokenGenerator
{
    string GenerateToken(ApplicationUser user, List<Claim> roleClaims);
}
