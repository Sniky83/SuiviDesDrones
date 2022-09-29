using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivi_des_drones.Core.Infrastructure.Databases
{
    public class DronesDbContextFactory : IDesignTimeDbContextFactory<DronesDbContext>
    {
        #region Public Methods
        public DronesDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DronesDbContext>();
            optionsBuilder.UseSqlServer("Server=.;Database=SuiviDesDrones;Trusted_Connection=True;");

            return new DronesDbContext(optionsBuilder.Options);
        }
        #endregion
    }
}
