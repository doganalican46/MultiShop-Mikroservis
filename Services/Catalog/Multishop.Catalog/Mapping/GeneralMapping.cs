using AutoMapper;
using Multishop.Catalog.Dtos.CagetoryDtos;
using Multishop.Catalog.Dtos.ProductDtos;
using Multishop.Catalog.Dtos.ProductDetailDtos;
using Multishop.Catalog.Dtos.ProductImageDtos;
using Multishop.Catalog.Entities;

namespace Multishop.Catalog.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping() 
        { 
            CreateMap<Category,ResultCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, GetByIDCategoryDto>().ReverseMap();

            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, GetByIDProductDto>().ReverseMap();

            CreateMap<ProductDetail, ResultProductDetailDto>().ReverseMap();
            CreateMap<ProductDetail, CreateProductDetailDto>().ReverseMap();
            CreateMap<ProductDetail, UpdateProductDetailDto>().ReverseMap();
            CreateMap<ProductDetail, GetByIDProductDetailDto>().ReverseMap();

            CreateMap<ProductImage, ResultProductImageDto>().ReverseMap();
            CreateMap<ProductImage, CreateProductImageDto>().ReverseMap();
            CreateMap<ProductImage, UpdateProductImageDto>().ReverseMap();
            CreateMap<ProductImage, GetByIDProductImageDto>().ReverseMap();


        }
    }
}
