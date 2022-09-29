using suivi_des_drones.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivi_des_drones.Core.Interfaces.Repositories
{
    /// <summary>
    /// Contrat pour tout repository gérant des drones
    /// </summary>
    public interface IDroneRepository
    {
        List<Drone> GetAll();

        /// <summary>
        /// Retourne un drone par son matricule
        /// </summary>
        /// <param name="matricule"></param>
        /// <returns></returns>
        Drone GetOne(string matricule);

        /// <summary>
        /// Ajout ou mise à jour d'un drone
        /// </summary>
        /// <param name="drone"></param>
        void Save(Drone drone);
    }
}
