using AutoMapper;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class ProductMapping : Profile
    {
        public ProductMapping()
        {
            CreateMap<Product, GetListProductResponse>().ForMember(destinationMember: p => p.CategoryName, memberOptions: opt => opt.MapFrom(p => p.Category.Name)).ReverseMap();
            CreateMap<CreateProductRequest, Product>();
            CreateMap<Product, CreatedProductResponse>();
            CreateMap<IPaginate<Product>, GetListProductResponse>();
        }
    }
}
