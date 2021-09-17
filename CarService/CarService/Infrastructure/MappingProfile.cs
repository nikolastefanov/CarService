

namespace CarService.Infrastructure
{
    using AutoMapper;
    using CarService.Data.Models;
    using CarService.Models.Cars;
    using CarService.Models.Reviews;
    using CarService.Services.Cars;
    using CarService.Services.Reviews;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            this.CreateMap<Review,ReviewServiceModel>();
            this.CreateMap<ReviewServiceModel, ReviewViewModel>();
            this.CreateMap< CarDetailsServiceModel,CarDetailsViewModel >();

        }
    }
}
