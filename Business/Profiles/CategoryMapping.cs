using AutoMapper;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Entities.Concretes;

namespace Business.Profiles
{
    public class CategoryMapping : Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category, CreateCategoryRequest>().ReverseMap();
            CreateMap<Category, CreatedCategoryResponse>().ReverseMap();
        }
    }
}
