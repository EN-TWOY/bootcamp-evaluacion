using Prueba.Application.Admins.Dtos.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Application.Admins.Services
{
    public interface IPermissionService
    {
        Task<IReadOnlyList<PermissionSmallDto>> FindAllAsync();

        Task<PermissionDto> FindByIdAsync(int id);

        Task<PermissionSimpleDto> CreateAsync(PermissionSaveDto saveDto);

        Task<PermissionSimpleDto> EditAsync(int id, PermissionSaveDto saveDto);

        Task<PermissionSimpleDto> DisabledAsync(int id);
    }
}
