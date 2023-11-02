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
        private BurgerRepository _repo;

        public OpretBurgerModel(BurgerRepository repo)
        {
            _repo = repo;
        }

        [BindProperty]
        public int NytBurgerNummer { get; set; }
        [BindProperty]
        [Required(ErrorMessage = "Der skal være et navn")]
        [StringLength(1000, MinimumLength = 2, ErrorMessage = "Der skal være mindst to tegn i et navn")]
        public string NytBurgerNavn { get; set; }
        [BindProperty]

        public string NytBurgerBeskrivelse { get; set; }
        [BindProperty]
        public double NytBurgerPris { get; set; }
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
            Burger nyBurger = new Burger(NytBurgerNummer, NytBurgerNavn, NytBurgerBeskrivelse, NytBurgerPris, NytBurgerVegan);

            //BurgerRepository repo = new BurgerRepository(true);
            _repo.Tilføj(nyBurger);

            return RedirectToPage("index");
        }

    }
}
