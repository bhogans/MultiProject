using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICore.Dtos;
using WebAPICore.Models;

namespace WebAPICore.Profiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<Address, AddressReadDto>();
            CreateMap<Location, LocationReadDto>();
        }
    }
}
