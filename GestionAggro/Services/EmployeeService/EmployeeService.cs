using Microsoft.EntityFrameworkCore;

namespace GestionAggro.Services.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        private readonly DataContext _context;

        public EmployeeService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Employee>> AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return await _context.Employees.ToListAsync();
        }

        public async Task<List<Employee>?> DeleteEmployee(int Id)
        {
            var employee = await _context.Employees.FindAsync(Id); ;
            if (employee is null)
                return null;

            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return await _context.Employees.ToListAsync();
        }

        public async Task<List<Employee>> GetAllEmployees()
        {
            var employees = await _context.Employees.ToListAsync();
            return employees;
        }

        public async Task<Employee?> GetSingleEmployee(int Id)
        {
            var employee = await _context.Employees.FindAsync(Id);
            if (employee is null)
            return null;

            return employee;
        }

        public async Task<List<Employee>?> UpdateEmployee(int Id, Employee request)
        {
            var employee = await _context.Employees.FindAsync(Id);
            if (employee is null)
                return null;

            employee.Firstname = request.Firstname;
            employee.Lastname = request.Lastname;
            employee.Cellphone = request.Cellphone;
            employee.Phone = request.Phone;
            employee.Email = request.Email;
            employee.ServiceId = request.ServiceId;
            employee.SiteId = request.SiteId;
            
        await _context.SaveChangesAsync();

        return await _context.Employees.ToListAsync();
        }
    }
}

