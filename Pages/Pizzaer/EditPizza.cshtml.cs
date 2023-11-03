using menukort.model;
using menukort.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace menukort.Pages.Pizzaer
{
    public class EditPizzaModel : PageModel
    {
        private PizzaRepository _repo;

        public EditPizzaModel(PizzaRepository repo)
        {
            _repo = repo;
        }

        [BindProperty]
        [Required(ErrorMessage = "Der skal være et nummer")]
        public int? NytPizzaNummer { get; set; }


        [BindProperty]
        [Required(ErrorMessage = "Der skal være et navn")]
        [StringLength(1000, MinimumLength = 2, ErrorMessage = "Der skal være mindst to tegn i et navn")]
        public string NytPizzaNavn { get; set; }


        [BindProperty]
        public string NytPizzaBeskrivelse { get; set; }


        [BindProperty]
        [Required(ErrorMessage = "Der skal være en pris")]
        public double NytPizzaPris { get; set; }


        [BindProperty]
        public bool NytPizzaVegan { get; set; }


        [BindProperty]
        public bool NytPizzaDeepPan { get; set; }


        [BindProperty]
        public bool NytPizzaFamilie { get; set; }


        public void OnGet(int nummer)
        {
            Pizza pizza = _repo.HentPizza(nummer);

            NytPizzaNummer = pizza.Nummer;
            NytPizzaNavn = pizza.Navn;
            NytPizzaBeskrivelse = pizza.Beskrivelse;
            NytPizzaPris = pizza.Pris;
            NytPizzaVegan = pizza.Vegan;
            NytPizzaDeepPan = pizza.DeepPan;
            NytPizzaFamilie = pizza.FamilieSize;
        }
        public IActionResult OnPostChange()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Pizza pizza = _repo.HentPizza(NytPizzaNummer ?? 0);

            pizza.Navn = NytPizzaNavn;
            pizza.Beskrivelse = NytPizzaBeskrivelse;
            pizza.Pris = NytPizzaPris;
            pizza.Vegan = NytPizzaVegan;
            pizza.DeepPan = NytPizzaDeepPan;
            pizza.FamilieSize = NytPizzaFamilie;


            return RedirectToPage("Index");
        }



        public IActionResult OnPostCancel()
        {
            return RedirectToPage("Index");
        }
    }
}
