using Microsoft.EntityFrameworkCore;

namespace GestionAggro.Services.ServiceService
{
    public class ServiceService : IServiceService
    {
        private readonly DataContext _context;

        public ServiceService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Service>> AddService(Service service)
        {
            _context.Services.Add(service);
            await _context.SaveChangesAsync();
            return await _context.Services.ToListAsync();
        }

        public async Task<List<Service>?> DeleteService(int Id)
        {
            var service = await _context.Services.FindAsync(Id); ;
            if (service is null)
                return null;

            _context.Services.Remove(service);
            await _context.SaveChangesAsync();
            return await _context.Services.ToListAsync();
        }

        public async Task<List<Service>> GetAllServices()
        {
            var services = await _context.Services.ToListAsync();
            return services;
        }

        public async Task<Service?> GetSingleService(int Id)
        {
            var service = await _context.Services.FindAsync(Id);
            if (service is null)
                return null;

            return service;
        }

        public async Task<List<Service>?> UpdateService(int Id, Service request)
        {
            var service = await _context.Services.FindAsync(Id);
            if (service is null)
                return null;

            service.Name = request.Name;

            await _context.SaveChangesAsync();

            return await _context.Services.ToListAsync();
        }
    }
}

