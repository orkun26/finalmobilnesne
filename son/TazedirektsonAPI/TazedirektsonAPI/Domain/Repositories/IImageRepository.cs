using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TazedirektsonAPI.Domain.Models;

namespace TazedirektsonAPI.Domain.Repositories
{
    public interface IImageRepository
    {
        Task<IEnumerable<Image>> ListAsync();
        Task AddAsync(Image image);
        Task<Image> FindByIdAsync(int id);
        void Update(Image image);
        void Remove(Image image);
    }
}
