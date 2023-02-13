using GestionAggro.Core;
using System.Text.Json.Serialization;

namespace GestionAggro.Models
{
    public class Employee : Entity
    {
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public string Cellphone { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        
        public int ServiceId { get; set; }
        public int SiteId { get; set; }
    }
}
