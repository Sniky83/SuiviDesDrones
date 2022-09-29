using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace suivi_des_drones.Web.UI.Pages
{
    public class CreateIncidentModel : PageModel
    {
        #region Fields
        private readonly IHostEnvironment _environment;
        #endregion

        #region Constructors
        public CreateIncidentModel(IHostEnvironment environment)
        {
            _environment = environment;
        }
        #endregion

        #region Public Methods
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            using var file = new FileStream(_environment.ContentRootPath + "./" + PictureFile.FileName, FileMode.OpenOrCreate);

            await PictureFile.CopyToAsync(file);

            return Page();
        }
        #endregion

        #region Properties
        [BindProperty]
        public IFormFile PictureFile { get; set; }
        #endregion
    }
}
