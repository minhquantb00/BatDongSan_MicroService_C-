using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Client, ClientDTO>();
            CreateMap<Estate, EstateDTO>();
            CreateMap<Listing, ListingDTO>();
            //CreateMap<SearchQuery, SearchViewModel>();

            // USERS
            // UserEntity -> UserResponse
            CreateMap<UserEntity, UserDto>();
            CreateMap<UserAttribute, AttributeDto>().ReverseMap();

            //CreateUserRequest -> UserEntity
            //CreateMap<CreateUserCommand, KeycloakUserEntity>();
        }
    }
}
