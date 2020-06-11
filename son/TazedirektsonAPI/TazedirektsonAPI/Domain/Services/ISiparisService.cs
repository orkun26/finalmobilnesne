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
    public interface ISiparisService
    {
        Task<IEnumerable<Siparis>> ListAsync();
        Task<SiparisResponse> SaveAsync(Siparis siparis);
        Task<SiparisResponse> UpdateAsync(int id, Siparis siparis);
        Task<SiparisResponse> DeleteAsync(int id);
        Task<IEnumerable<Siparis>> FindByEmailAsync(string email);
    }
}

