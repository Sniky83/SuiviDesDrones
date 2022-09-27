using Microsoft.EntityFrameworkCore;
using suivi_des_drones.Core.Infrastructure.Databases;
using suivi_des_drones.Core.Interfaces.Infrastructures;
using suivi_des_drones.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivi_des_drones.Core.Infrastructure.DataLayers
{
    public class SqlServerDroneDataLayer : BaseSqlServerDataLayer, IDroneDataLayer
    {
        #region Constructors
        public SqlServerDroneDataLayer(DronesDbContext context) : base(context) { }
        #endregion

        #region Public Methods
        public void AddOne(Drone drone)
        {
            Context?.Drones.Add(drone);

            //var entry = _context?.Entry(drone.HealthStatus);
            //entry.State = Microsoft.EntityFrameworkCore.EntityState.Unchanged;

            Context?.SaveChanges();
        }

        public List<Drone> GetList()
        {
            //using var context = new DronesDbContext();

            var query = from item in Context.Drones.Include(item => item.HealthStatus)
                        select item;

            return query.ToList();
        }
        #endregion
    }
}
