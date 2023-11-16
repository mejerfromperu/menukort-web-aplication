using menukort.model;
using menukort.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace menukort.Pages.Burgere
{
    public class OpretBurgerModel : PageModel
    {
        private IBurgerRepository _repo;

        public OpretBurgerModel(IBurgerRepository repo)
        {
            _repo = repo;
        }

        [BindProperty]
        [Required(ErrorMessage = "Der skal v�re et nummer")]
        public int? NytBurgerNummer { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Der skal v�re et navn")]
        [StringLength(1000, MinimumLength = 2, ErrorMessage = "Der skal v�re mindst to tegn i et navn")]
        public string NytBurgerNavn { get; set; }

        [BindProperty]
        public string NytBurgerBeskrivelse { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Der skal v�re en pris")]
        public double? NytBurgerPris { get; set; }

        [BindProperty]
        public bool NytBurgerVegan { get; set; }

        public void OnGet()
        {



        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Burger nyBurger = new Burger ((int) NytBurgerNummer, NytBurgerNavn, NytBurgerBeskrivelse, (double) NytBurgerPris, NytBurgerVegan);

            //BurgerRepository repo = new BurgerRepository(true);
            _repo.Tilføj(nyBurger);

            return RedirectToPage("index");
        }

    }
}
