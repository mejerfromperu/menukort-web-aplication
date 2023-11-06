using menukort.model;
using menukort.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace menukort.Pages.Burgere
{
    public class EditBurgerModel : PageModel
    {
        private IBurgerRepository _repo;

        public EditBurgerModel(IBurgerRepository repo)
        {
            _repo = repo;
        }

        [BindProperty]
        [Required(ErrorMessage = "Der skal være et nummer")]
        public int? NytBurgerNummer { get; set; }


        [BindProperty]
        [Required(ErrorMessage = "Der skal være et navn")]
        [StringLength(1000, MinimumLength = 2, ErrorMessage = "Der skal være mindst to tegn i et navn")]
        public string NytBurgerNavn { get; set; }


        [BindProperty]
        public string NytBurgerBeskrivelse { get; set; }


        [BindProperty]
        [Required(ErrorMessage = "Der skal være en pris")]
        public double NytBurgerPris { get; set; }


        [BindProperty]
        public bool NytBurgerVegan { get; set; }



        public void OnGet(int nummer)
        {
            Burger burger = _repo.HentBurger(nummer);

            NytBurgerNummer = burger.Nummer;
            NytBurgerNavn = burger.Navn;
            NytBurgerBeskrivelse = burger.Beskrivelse;
            NytBurgerPris = burger.Pris;
            NytBurgerVegan = burger.Vegan;
        }
        public IActionResult OnPostChange()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Burger burger = _repo.HentBurger(NytBurgerNummer ?? 0);

            burger.Navn = NytBurgerNavn;
            burger.Beskrivelse = NytBurgerBeskrivelse;
            burger.Pris = NytBurgerPris;
            burger.Vegan = NytBurgerVegan;


            return RedirectToPage("Index");
        }



        public IActionResult OnPostCancel()
        {
            return RedirectToPage("Index");
        }
    }
}
