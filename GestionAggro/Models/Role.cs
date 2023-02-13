using GestionAggro.Core;

namespace GestionAggro.Models
{
    public class Role : Entity
    {
        public string Name { get; set; } = string.Empty;

        public User User { get; set; }
    }
}
