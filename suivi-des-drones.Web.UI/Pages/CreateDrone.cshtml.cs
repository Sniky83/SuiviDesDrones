using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using suivi_des_drones.Core.Interfaces.Repositories;
using suivi_des_drones.Core.Models;

namespace suivi_des_drones.Web.UI.Pages
{
    [Authorize]
    public class CreateDroneModel : PageModel
    {
        private readonly IDroneRepository _repository;
        public CreateDroneModel(IDroneRepository repository)
        {
            _repository = repository;
        }

        public void OnGet()
        {
        }

        //public void OnPost(string matricule)
        public void OnPost(/*Drone drone*/)
        {
            //Vérifie les data anotations
            if(ModelState.IsValid)
            {
                //string matricule = this.Request.Form["matricule"];
                _repository.Save(MonDrone);
                MonDrone = new Drone();
                ModelState.Clear();
            }
        }

        [BindProperty]
        //Récupère les values associés au champ depuis le front
        public Drone MonDrone { get; set; }
    }
}
