using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TazedirektsonAPI.Domain.Models;
using TazedirektsonAPI.Domain.Services.Communication;

namespace TazedirektsonAPI.Domain.Services
{
    public interface IImageService
    {
        Task<IEnumerable<Image>> ListAsync();
        Task<ImageResponse> SaveAsync(Image image);
        Task<ImageResponse> UpdateAsync(int id, Image image);
        Task<ImageResponse> DeleteAsync(int id);
    }
}
