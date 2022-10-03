using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using suivi_des_drones.Core.Infrastructure.Databases;
using suivi_des_drones.Core.Infrastructure.DataLayers;
using suivi_des_drones.Core.Interfaces.Infrastructures;
using suivi_des_drones.Core.Interfaces.Repositories;
using suivi_des_drones.Core.Models;

namespace suivi_des_drones.Web.UI.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
        #region Fields
        private readonly ILogger<IndexModel> _logger;
        private readonly IDroneRepository _repository;
        #endregion

        #region Constructors
        public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration, IDroneRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }
        #endregion

        #region Properties
        public List<Drone> Drones { get; set; } = new();
        public List<HealthStatus> StatusList { get; set; } = new();
        #endregion

        #region Internal Methods
        private void SetListOfDrones()
        {
            //this.Drones.Add(new() { Matricule = "54XXD0", CreationDate = DateTime.Now, HealthStatus = HealthStatus.OK });
            //this.Drones.Add(new() { Matricule = "15FR2E", CreationDate = DateTime.Now.AddDays(-150), HealthStatus = HealthStatus.Broken });

            //var dataLayer = new SqlServerDroneDataLayer();

            Drones = _repository.GetAll();
        }

        private void SetListOfStatus()
        {
            this.StatusList.Add(HealthStatus.OK);
            this.StatusList.Add(HealthStatus.Repair);
            this.StatusList.Add(HealthStatus.Broken);
        }
        #endregion

        #region Public Methods
        public async Task<IActionResult> OnGetAsync()
        {
            IActionResult result = Page();

            throw new NotImplementedException();

            this.SetListOfDrones();
            this.SetListOfStatus();

            return result;
        }
        #endregion
    }
}