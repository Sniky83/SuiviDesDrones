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
    public interface IUserDataLayer
    {
        /// <summary>
        /// Selectionne un utilisateur en base
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        CompleteUser GetOne(string email, string password);
    }
}
