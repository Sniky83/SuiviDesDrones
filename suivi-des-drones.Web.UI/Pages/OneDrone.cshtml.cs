using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using suivi_des_drones.Core.Interfaces.Repositories;
using suivi_des_drones.Core.Models;

namespace suivi_des_drones.Web.UI.Pages
{
    public class OneDroneModel : PageModel
    {
        #region Fields
        private readonly IDroneRepository _repository;
        #endregion

        #region Constructors
        public OneDroneModel(IDroneRepository repository)
        {
            _repository = repository;
        }
        #endregion

        #region Public Methods
        public IActionResult OnGet()
        {
            IActionResult result = Page();

            try
            {
                Drone = _repository.GetOne(Matricule);
            }
            catch (Exception)
            {
                result = NotFound();
            }

            return result;
        }
        #endregion

        #region Properties
        [BindProperty(SupportsGet = true)]
        public string Matricule { get; set; }

        public Drone? Drone { get; set; }
        #endregion
    }
}
