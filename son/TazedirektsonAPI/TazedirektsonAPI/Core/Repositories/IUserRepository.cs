using System.Threading.Tasks;
using TazedirektsonAPI.Core.Models;

namespace TazedirektsonAPI.Core.Repositories
{
    public interface IUserRepository
    {
        Task AddAsync(User user, ERole[] userRoles);
        Task<User> FindByEmailAsync(string email);
        void Update(User user);
    }
}