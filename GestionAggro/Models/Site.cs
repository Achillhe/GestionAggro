﻿using GestionAggro.Core;

namespace GestionAggro.Models
{
    public class Site : Entity
    {
        public string City { get; set; } = string.Empty;

        public ICollection<Employee> Employees { get; set; }
    }
}
