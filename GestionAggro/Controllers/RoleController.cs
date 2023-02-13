using GestionAggro.Services.RoleService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GestionAggro.Models;

namespace GestionAggro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Role>>> GetAllRoles()
        {
            return await _roleService.GetAllRoles();
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Role>> GetSingleRole(int Id)
        {
            var result = await _roleService.GetSingleRole(Id);
            if (result is null)
                return NotFound("Employé non trouvé.");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Role>>> AddRole([FromBody] Role role)
        {
            var result = await _roleService.AddRole(role);
            return Ok(result);
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult<List<Role>>> UpdateRole(int Id, Role request)
        {
            var result = await _roleService.UpdateRole(Id, request);
            if (result is null)
                return NotFound("Employé non trouvé.");

            return Ok(result);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<List<Role>>> DeleteRole(int Id)
        {
            var result = await _roleService.DeleteRole(Id);
            if (result is null)
                return NotFound("Employé non trouvé.");

            return Ok(result);
        }
    }
}
