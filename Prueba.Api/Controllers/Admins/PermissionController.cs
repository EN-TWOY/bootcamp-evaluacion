using Prueba.Application.Admins.Services;
using Microsoft.AspNetCore.Mvc;
using Prueba.Application.Admins.Dtos.Permissions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Prueba.Api.Controllers.Admins
{
    [ApiController]
    [Route("api/[controller]")]
    public class PermissionController : ControllerBase
    {
        private readonly IPermissionService _permissionService;

        public PermissionController(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }

        [HttpGet]
        public async Task<IEnumerable<PermissionSmallDto>> Get()
        {
            return await _permissionService.FindAllAsync();
        }


        [HttpGet("{id}")]
        public async Task<PermissionDto> Get(int id)
        {
            return await _permissionService.FindByIdAsync(id);
        }

        [HttpPost]
        public async Task<PermissionSimpleDto> Post([FromBody] PermissionSaveDto saveDto)
        {
            return await _permissionService.CreateAsync(saveDto);
        }

        [HttpPut("{id}")]
        public async Task<PermissionSimpleDto> Put(int id, [FromBody] PermissionSaveDto saveDto)
        {
            return await _permissionService.EditAsync(id, saveDto);
        }

        [HttpDelete("{id}")]
        public async Task<PermissionSimpleDto> Delete(int id)
        {
            return await _permissionService.DisabledAsync(id);
        }
    }
}

