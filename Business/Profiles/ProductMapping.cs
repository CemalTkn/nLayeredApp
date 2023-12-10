﻿using AutoMapper;
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
            CreateMap<CreateProductRequest, Product>();
            CreateMap<Product, CreatedProductResponse>();
            CreateMap<IPaginate<Product>, GetListResponse>();
            CreateMap<Product, ProductListDto>();
        }
    }
}