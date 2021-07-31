using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class RentedProperty
    {
        public int Id { get; set; }
        public Address Address { get; set; }
        public bool HasFireAlaram { get; set; }
        public bool HasCo2Alaram { get; set; }
        public Tenant Tenant { get; set; }
        public PropertyStatus PropertyStatus { get; set; }
    }

    public enum PropertyStatus
    {
        Occupied = 1,
        Empty = 2,
        Upcoming_Renewel = 3
    }
}
