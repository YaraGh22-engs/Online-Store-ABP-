using AbpCourse.Demo.Categories;
using AbpCourse.Demo.Entities.Categories;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpCourse.Demo.Mapping
{
    public class CategoryMappingProfile : Profile // profile is auto Mapper
    {
        public CategoryMappingProfile()
        {
            CreateMap<Category,CategoryDto>();
            CreateMap<CreateUpdateCategoryDto, Category>();
        }
    }
}
