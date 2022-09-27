using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivi_des_drones.Core.Models
{
    /*public enum HealthStatus
    {
        OK = 0,
        Broken = -1,
        Repair = -2
    }*/

    public record HealthStatus
    {
        public static HealthStatus OK = new HealthStatus() { Id = 0, Label = "OK" };
        public static HealthStatus Broken = new HealthStatus() { Id = -1, Label = "Cassé" };
        public static HealthStatus Repair = new HealthStatus() { Id = -2, Label = "En réparation" };
        public decimal Id { get; init; }
        public string Label { get; init; } = default!;
        public List<Drone>? Drones { get; set; }
    }
}
