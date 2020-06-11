using System.Threading.Tasks;
using TazedirektsonAPI.Core.Models;
using TazedirektsonAPI.Core.Services.Communication;
using TazedirektsonAPI.Domain.Services.Communication;

namespace TazedirektsonAPI.Core.Services
{
    public interface IUserService
    {
        Task<CreateUserResponse> CreateUserAsync(User user, params ERole[] userRoles);
        Task<User> FindByEmailAsync(string email);
        Task<CreateUserResponse> UpdateAsync(string email, User user);
    }
}