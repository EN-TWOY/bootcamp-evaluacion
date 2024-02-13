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

        Task<PermissionDto> CreateAsync(PermissionSaveDto saveDto);

        Task<PermissionDto> EditAsync(int id, PermissionSaveDto saveDto);

        Task<PermissionDto> DisabledAsync(int id);
    }
}
