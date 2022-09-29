using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivi_des_drones.Core.Models
{
    public class Incident
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Drone Drone { get; set; }
        public string Reason { get; set; }
    }
}
