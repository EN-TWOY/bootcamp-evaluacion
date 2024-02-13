using AutoMapper;
using Prueba.Domain.Admins.Models;

namespace Prueba.Application.Admins.Dtos.Permissions.Profiles
{
    public class PermissionProfile : Profile
    {
        public PermissionProfile()
        {
            CreateMap<Permission, PermissionDto>();
            CreateMap<Permission, PermissionSmallDto>();
            CreateMap<Permission, PermissionSimpleDto>();

            CreateMap<Permission, PermissionSaveDto>().ReverseMap();
        }
    }
}
