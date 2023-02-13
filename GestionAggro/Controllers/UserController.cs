using GestionAggro.Services.UserService;
using Microsoft.AspNetCore.Mvc;

namespace GestionAggro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAllUsers()
        {
            return await _userService.GetAllUsers();
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<User>> GetSingleUser(int Id)
        {
            var result = await _userService.GetSingleUser(Id);
            if (result is null)
                return NotFound("Employé non trouvé.");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<User>>> AddUser([FromBody] User user)
        {
            var result = await _userService.AddUser(user);
            return Ok(result);
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult<List<User>>> UpdateUser(int Id, User request)
        {
            var result = await _userService.UpdateUser(Id, request);
            if (result is null)
                return NotFound("Employé non trouvé.");

            return Ok(result);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<List<User>>> DeleteUser(int Id)
        {
            var result = await _userService.DeleteUser(Id);
            if (result is null)
                return NotFound("Employé non trouvé.");

            return Ok(result);
        }
    }
}