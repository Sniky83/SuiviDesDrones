using suivi_des_drones.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivi_des_drones.Core.Interfaces.Infrastructures
{
    /// <summary>
    /// Isole l'accès à la base de données
    /// </summary>
    public interface IDroneDataLayer
    {
        /// <summary>
        /// Retourne la liste complète
        /// </summary>
        List<Drone> GetList();

        /// <summary>
        /// Appel la base pour retourner un Drone
        /// </summary>
        /// <param name="matricule"></param>
        /// <returns></returns>
        Drone GetOne(string matricule);

        /// <summary>
        /// Permet l'ajout d'un nouveau drone en BDD
        /// </summary>
        /// <param name="drone"></param>
        void AddOne(Drone drone);
    }
}
