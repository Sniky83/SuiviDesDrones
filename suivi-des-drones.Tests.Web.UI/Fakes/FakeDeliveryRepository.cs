using suivi_des_drones.Core.Interfaces.Repositories;
using suivi_des_drones.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivi_des_drones.Tests.Web.UI.Fakes
{
    internal class FakeDeliveryRepository : IDeliveryRepository
    {
        public List<Delivery> GetAll()
        {
            return new()
            {
                new(),
                new()
            };
        }
    }
}
