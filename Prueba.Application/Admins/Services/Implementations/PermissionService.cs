using Prueba.Application.Admins.Dtos.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Application.Admins.Services.Implementations
{
    public class PermissionService : IPermissionService
    {
        public Task<PermissionSimpleDto> CreateAsync(PermissionSaveDto saveDto)
        {
            throw new NotImplementedException();
        }

        public Task<PermissionSimpleDto> DisabledAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PermissionSimpleDto> EditAsync(int id, PermissionSaveDto saveDto)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<PermissionSmallDto>> FindAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PermissionDto> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
