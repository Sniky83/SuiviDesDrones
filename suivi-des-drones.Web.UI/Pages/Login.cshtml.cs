using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using suivi_des_drones.Core.Interfaces.Repositories;
using suivi_des_drones.Core.Models;

namespace suivi_des_drones.Web.UI.Pages
{
    public class LoginModel : PageModel
    {
        #region Properties
        [BindProperty]
        public new AuthenticationUser? User { get; set; }
        #endregion

        #region Fields
        private readonly IUserRepository _repository;
        #endregion

        #region Constructors
        public LoginModel(IUserRepository repository)
        {
            _repository = repository;
        }
        #endregion

        #region Public Methods
        public IActionResult OnPost()
        {
            IActionResult result = Page();

            try
            {
                var user = _repository.LogIn(User);

                if (user != null)
                {
                    HttpContext.Session.SetString("UserId", user.Login);
                    result = RedirectToPage("/Index");
                }
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }
        #endregion
    }
}
