using DataAccess.Entities;
using System.Security.Claims;

namespace API.Services
{
    public interface ITokenService
    {
        string GenerateToken(AppUser user);
        string GenerateRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}
