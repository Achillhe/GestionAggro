namespace GestionAggro.Services.SiteService
{
    public interface ISiteService
    {
        Task<List<Site>> GetAllSites();
        Task<Site>? GetSingleSite(int Id);
        Task<List<Site>> AddSite(Site site);
        Task<List<Site>?> UpdateSite(int Id, Site request);
        Task<List<Site>?> DeleteSite(int Id);
    }
}