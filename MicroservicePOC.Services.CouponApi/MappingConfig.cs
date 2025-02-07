using AutoMapper;
using MicroservicePOC.Services.CouponApi.Models;
using MicroservicePOC.Services.CouponApi.Models.Dto;

namespace MicroservicePOC.Services.CouponApi
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Coupon, CouponDto>();
                config.CreateMap<CouponDto, Coupon>();
            });

            return mappingConfig;
        }
    }
}
