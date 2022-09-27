using suivi_des_drones.Core.Interfaces.Infrastructures;
using suivi_des_drones.Core.Interfaces.Repositories;
using suivi_des_drones.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivi_des_drones.Core.Application.Repositories
{
    public class UserRepository : IUserRepository
    {
        #region Fields
        private readonly IUserDataLayer _layer;
        #endregion

        #region Constructors
        public UserRepository(IUserDataLayer layer)
        {
            _layer = layer;
        }
        #endregion

        #region Public Methods
        public CompleteUser LogIn(AuthenticationUser user)
        {
            var userData = _layer.GetOne(user.Login, user.Password);

            if(userData == null)
            {
                throw new ArgumentNullException(nameof(userData));
            }

            return userData;
        }
        #endregion
    }
}
