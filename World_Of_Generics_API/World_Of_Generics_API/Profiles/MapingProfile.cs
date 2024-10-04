using AutoMapper;
using World_Of_Generics_API.DTOs;
using World_Of_Generics_API.Models;

namespace World_Of_Generics_API.Profiles
{
    public class MapingProfile : Profile
    {
        public MapingProfile()
        {
            CreateMap<Product, ProductDTO>();
            CreateMap<Category, CategoryDTO>(); 
            CreateMap<ProductDTO, Product>();
            CreateMap<CategoryDTO, Category>();
        }
    }
}
