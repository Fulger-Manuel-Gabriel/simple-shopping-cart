using AutoMapper;
using SchoolOf.Data.Models;
using SchoolOf.Dtos;

namespace SchoolOf.Mappers
{
    public class OrdersMapperProfile : Profile
    {
        public OrdersMapperProfile()
        {
            CreateMap<Order, OrderDto>();
        }
    }
}
