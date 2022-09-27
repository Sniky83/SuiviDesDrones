﻿using suivi_des_drones.Core.Interfaces.Infrastructures;
using suivi_des_drones.Core.Interfaces.Repositories;
using suivi_des_drones.Core.Models;

namespace suivi_des_drones.Core.Application.Repositories
{
    /// <summary>
    /// Repository qui gère les drones, la création, la lecture, ...
    /// </summary>
    public class DroneRepository : IDroneRepository
    {
        #region Fileds
        private readonly IDroneDataLayer _dataLayer;
        #endregion

        #region Constructors
        public DroneRepository(IDroneDataLayer dataLayer)
        {
            _dataLayer = dataLayer;
        }
        #endregion

        #region Public methods
        /// <summary>
        /// Retourne la liste complète des drones
        /// </summary>
        /// <returns></returns>
        public List<Drone> GetAll()
        {
            /*return new ()
            {
                new (),
                new Drone()
            };*/

            List<Drone> list = _dataLayer.GetList();

            return list;
        }

        public void Save(Drone drone)
        {
            drone.HealthStatusId = HealthStatus.Broken.Id;

            _dataLayer.AddOne(drone);
        }
        #endregion
    }
}