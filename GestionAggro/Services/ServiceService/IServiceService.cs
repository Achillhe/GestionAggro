namespace GestionAggro.Services.ServiceService
{
    public interface IServiceService
    {
        Task<List<Service>> GetAllServices();
        Task<Service>? GetSingleService(int Id);
        Task<List<Service>> AddService(Service service);
        Task<List<Service>?> UpdateService(int Id, Service request);
        Task<List<Service>?> DeleteService(int Id);
    }
}

