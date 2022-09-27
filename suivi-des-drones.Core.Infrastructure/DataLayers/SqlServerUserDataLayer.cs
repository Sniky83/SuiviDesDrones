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
    public class SqlServerUserDataLayer : BaseSqlServerDataLayer, IUserDataLayer
    {
        #region Constructors
        public SqlServerUserDataLayer(DronesDbContext context) : base(context) {}
        #endregion

        #region Public Methods
        public CompleteUser GetOne(string email, string password)
        {
            return Context.Users.Where(item => item.Login == email && item.Password == password).First();
        }
        #endregion
    }
}
