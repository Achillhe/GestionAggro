using Microsoft.EntityFrameworkCore;

namespace GestionAggro.Services.SiteService
{
    public class SiteService : ISiteService
    {
        private readonly DataContext _context;

        public SiteService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Site>> AddSite(Site site)
        {
            _context.Sites.Add(site);
            await _context.SaveChangesAsync();
            return await _context.Sites.ToListAsync();
        }

        public async Task<List<Site>?> DeleteSite(int Id)
        {
            var site = await _context.Sites.FindAsync(Id); ;
            if (site is null)
                return null;

            _context.Sites.Remove(site);
            await _context.SaveChangesAsync();
            return await _context.Sites.ToListAsync();
        }

        public async Task<List<Site>> GetAllSites()
        {
            var sites = await _context.Sites.ToListAsync();
            return sites;
        }

        public async Task<Site?> GetSingleSite(int Id)
        {
            var site = await _context.Sites.FindAsync(Id);
            if (site is null)
                return null;

            return site;
        }

        public async Task<List<Site>?> UpdateSite(int Id, Site request)
        {
            var site = await _context.Sites.FindAsync(Id);
            if (site is null)
                return null;

            site.City = request.City;

            await _context.SaveChangesAsync();

            return await _context.Sites.ToListAsync();
        }
    }
}