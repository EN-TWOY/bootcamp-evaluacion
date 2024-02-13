using AutoMapper;
using Microsoft.Extensions.Logging;
using Prueba.Application.Admins.Dtos.Permissions;
using Prueba.Domain.Admins.Models;
using Prueba.Domain.Admins.Repositories;

namespace Prueba.Application.Admins.Services.Implementations
{
    public class PermissionService : IPermissionService
    {

        private readonly IPermissionRepository _permissionRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<PermissionService> _logger;

        public PermissionService(IPermissionRepository permissionRepository, IMapper mapper, ILogger<PermissionService> logger)
        {
            _permissionRepository = permissionRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<PermissionDto> CreateAsync(PermissionSaveDto saveDto)
        {
            var permission = _mapper.Map<Permission>(saveDto);

            permission.RegistrationDate = DateTime.Now;
            permission.State = true;

            await _permissionRepository.SaveAsync(permission);


            return _mapper.Map<PermissionDto>(permission);
        }

        public async Task<PermissionDto> DisabledAsync(int id)
        {
            var permission = await _permissionRepository.FindByIdAsync(id);

            if (permission is null)
            {
            }

            permission.State = false;

            await _permissionRepository.SaveAsync(permission);

            return _mapper.Map<PermissionDto>(permission);
        }

        public async Task<PermissionDto> EditAsync(int id, PermissionSaveDto saveDto)
        {
            var permission = await _permissionRepository.FindByIdAsync(id);

            if (permission is null)
            {
            }

            _mapper.Map<PermissionSaveDto, Permission>(saveDto, permission);

            await _permissionRepository.SaveAsync(permission);

            return _mapper.Map<PermissionDto>(permission);
        }

        public async Task<IReadOnlyList<PermissionSmallDto>> FindAllAsync()
        {
            var permissions = await _permissionRepository.FindAllAsync();

            return _mapper.Map<IReadOnlyList<PermissionSmallDto>>(permissions);
        }

        public async Task<PermissionDto> FindByIdAsync(int id)
        {
            var permission = await _permissionRepository.FindByIdAsync(id);

            _logger.LogInformation("permission:" + permission?.Id);

            if (permission is null)
            {
                // hacer algo
                _logger.LogWarning("[AreaService] - [FindByIdAsync]: No se encontro un registro de Area para el id: " + id);
            }

            return _mapper.Map<PermissionDto>(permission);
        }
    }
}
