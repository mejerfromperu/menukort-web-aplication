using menukort.model;
using menukort.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography.X509Certificates;

namespace menukort.Pages.Burgere
{
    public class OpretBurgerModel : PageModel
    {
        [BindProperty]
        public int NytBurgerNummer { get; set; }
        [BindProperty]

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

        public void OnPost()
        {
            Burger nyBurger = new Burger(NytBurgerNummer, NytBurgerNavn, NytBurgerBeskrivelse, NytBurgerPris, NytBurgerVegan);

            BurgerRepository repo = new BurgerRepository(true);
            repo.Tilføj(nyBurger);
        }

    }
}
