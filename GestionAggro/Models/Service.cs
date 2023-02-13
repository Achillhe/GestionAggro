using GestionAggro.Core;

namespace GestionAggro.Models
{
    public class Service : Entity
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<Employee> Employees { get; set; }
    }
}
