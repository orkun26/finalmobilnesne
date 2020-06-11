using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TazedirektsonAPI.Domain.Models;
using TazedirektsonAPI.Domain.Services;
using TazedirektsonAPI.Domain.Repositories;
using TazedirektsonAPI.Persistence.Repositories;
using TazedirektsonAPI.Domain.Services.Communication;

namespace TazedirektsonAPI.Domain.Services
{
    public interface ISepetService
    {
        Task<IEnumerable<Sepet>> ListAsync();
        Task<SepetResponse> SaveAsync(Sepet sepet);
        Task<SepetResponse> UpdateAsync(int id, Sepet sepet);
        Task<SepetResponse> DeleteAsync(int id);
        Task<IEnumerable<Sepet>> FindByEmailAsync(string email);
    }
}

