using AutoMapper;
using Online_Store.Domain.Entities;
using Online_Store.Models;

namespace Online_Store.Service
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductViewModel>();
        }
    }
}
