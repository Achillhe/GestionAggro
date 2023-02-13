using GestionAggro.Services.EmployeeService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GestionAggro.Models;

namespace GestionAggro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Employee>>> GetAllEmployees()
        {
            return await _employeeService.GetAllEmployees();
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Employee>> GetSingleEmployee(int Id)
        {
            var result = await _employeeService.GetSingleEmployee(Id);
            if (result is null)
            return NotFound("Employé non trouvé.");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Employee>>> AddEmployee([FromBody] Employee employee)
        {
            var result = await _employeeService.AddEmployee(employee);
            return Ok(result);
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult<List<Employee>>> UpdateEmployee(int Id, Employee request)
        {
            var result = await _employeeService.UpdateEmployee(Id, request);
            if (result is null)
            return NotFound("Employé non trouvé.");

            return Ok(result);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<List<Employee>>> DeleteEmployee(int Id)
        {
            var result = await _employeeService.DeleteEmployee(Id);
            if (result is null)
                return NotFound("Employé non trouvé.");

            return Ok(result);
        }
    }
}
