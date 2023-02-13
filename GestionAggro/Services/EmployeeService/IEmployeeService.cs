namespace GestionAggro.Services.EmployeeService
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetAllEmployees();
        Task<Employee>? GetSingleEmployee(int Id);
        Task<List<Employee>> AddEmployee(Employee employee);
        Task<List<Employee>?> UpdateEmployee(int Id, Employee request);
        Task<List<Employee>?> DeleteEmployee(int Id);
    }
}
