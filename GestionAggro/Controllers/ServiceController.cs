using GestionAggro.Services.ServiceService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GestionAggro.Models;

namespace GestionAggro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Service>>> GetAllServices()
        {
            return await _serviceService.GetAllServices();
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Service>> GetSingleService(int Id)
        {
            var result = await _serviceService.GetSingleService(Id);
            if (result is null)
                return NotFound("Service non trouvé.");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Service>>> AddService([FromBody] Service service)
        {
            var result = await _serviceService.AddService(service);
            return Ok(result);
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult<List<Service>>> UpdateService(int Id, Service request)
        {
            var result = await _serviceService.UpdateService(Id, request);
            if (result is null)
                return NotFound("Service non trouvé.");

            return Ok(result);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<List<Service>>> DeleteService(int Id)
        {
            var result = await _serviceService.DeleteService(Id);
            if (result is null)
                return NotFound("Service non trouvé.");

            return Ok(result);
        }
    }
}