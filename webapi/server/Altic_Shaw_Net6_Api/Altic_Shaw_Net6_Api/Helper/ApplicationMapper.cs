using AutoMapper;
using Altic_Shaw_Net6_Api.Models;
using Altic_Shaw_Net6_Api.Entities;

namespace Altic_Shaw_Net6_Api.Helper
{
    public class ApplicationMapper: Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Product, ProductModel>().ReverseMap();
        }
    }   
}
