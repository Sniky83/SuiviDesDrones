using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NuGet.Protocol.Core.Types;
using suivi_des_drones.Core.Interfaces.Repositories;
using suivi_des_drones.Core.Models;

namespace suivi_des_drones.Web.UI.Pages
{
    public class DeliveryListModel : PageModel
    {
        #region Fields
        private readonly IDeliveryRepository _repository;
        #endregion

        #region Constructors
        public DeliveryListModel(IDeliveryRepository repository)
        {
            _repository = repository;
        }
        #endregion

        public IActionResult OnGet()
        {
            List = _repository.GetAll();

            return Page();
        }

        public List<Delivery> List { get; set; } = new List<Delivery>();
    }
}
