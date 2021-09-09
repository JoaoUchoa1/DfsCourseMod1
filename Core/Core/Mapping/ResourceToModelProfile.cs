using Core.Domain.Models;
using Core.Resource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace Core.Mapping
{
    public class ResouceToModelProfile : Profile
    {
        public ResouceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();
        }
    }
}
