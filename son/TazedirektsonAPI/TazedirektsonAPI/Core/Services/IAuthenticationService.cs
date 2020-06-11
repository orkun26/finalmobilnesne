using System.Threading.Tasks;
using TazedirektsonAPI.Core.Services.Communication;

namespace TazedirektsonAPI.Core.Services
{
    public interface IAuthenticationService
    {
         Task<TokenResponse> CreateAccessTokenAsync(string email, string password);
         Task<TokenResponse> RefreshTokenAsync(string refreshToken, string userEmail);
         void RevokeRefreshToken(string refreshToken);
    }
}