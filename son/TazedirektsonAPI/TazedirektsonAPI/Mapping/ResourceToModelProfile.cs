using AutoMapper;
using TazedirektsonAPI.Controllers.Resources;
using TazedirektsonAPI.Core.Models;
using TazedirektsonAPI.Domain.Models;
using TazedirektsonAPI.Resources;

namespace TazedirektsonAPI.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();
            CreateMap<SaveProductResource, Product>();
            CreateMap<SaveImageResource, Image>();
            CreateMap<SaveSiparisResource, Siparis>();
            CreateMap<SaveSepetResource, Sepet>();
            CreateMap<UserCredentialsResource, User>();
        }
    }
}