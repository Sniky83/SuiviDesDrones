using suivi_des_drones.Core.Infrastructure.Databases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivi_des_drones.Core.Infrastructure.DataLayers
{
    /// <summary>
    /// Classe parent pour tous les dataLayers qui vont avoir besoin du context
    /// Cette classe est abstract pour ne pas qu'on puisse l'instancier
    /// </summary>
    public abstract class BaseSqlServerDataLayer
    {
        #region Fields
        private readonly DronesDbContext? _context = null;
        #endregion

        #region Constructors
        public BaseSqlServerDataLayer(DronesDbContext context)
        {
            _context = context;
        }
        #endregion

        #region Properties
        protected DronesDbContext Context { get => _context;  }
        #endregion
    }
}
