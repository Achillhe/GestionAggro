using GestionAggro.Services.SiteService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GestionAggro.Models;

namespace GestionAggro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class SiteController : ControllerBase
    {
        private readonly ISiteService _siteService;

        public SiteController(ISiteService siteService)
        {
            _siteService = siteService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Site>>> GetAllSites()
        {
            return await _siteService.GetAllSites();
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Site>> GetSingleSite(int Id)
        {
            var result = await _siteService.GetSingleSite(Id);
            if (result is null)
                return NotFound("Site non trouvé.");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Site>>> AddSite([FromBody] Site site)
        {
            var result = await _siteService.AddSite(site);
            return Ok(result);
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult<List<Site>>> UpdateSite(int Id, Site request)
        {
            var result = await _siteService.UpdateSite(Id, request);
            if (result is null)
                return NotFound("Site non trouvé.");

            return Ok(result);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<List<Site>>> DeleteSite(int Id)
        {
            var result = await _siteService.DeleteSite(Id);
            if (result is null)
                return NotFound("Site non trouvé.");

            return Ok(result);
        }
    }
}
