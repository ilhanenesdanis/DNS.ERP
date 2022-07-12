using AutoMapper;
using Core.Entity;
using DTO;

namespace Manager.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Personnel, PersonnelDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Brand, BrandDTO>().ReverseMap();
        }
    }
}
