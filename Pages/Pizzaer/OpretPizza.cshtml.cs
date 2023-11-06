using menukort.model;
using menukort.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace menukort.Pages.Pizzaer
{
    public class OpretPizzaModel : PageModel
    {
        private IPizzaRepository _repo;

        public OpretPizzaModel(IPizzaRepository repo)
        {
            _repo = repo;
        }


        [BindProperty]
        [Required(ErrorMessage ="Der skal v�re et nummer")]
        public int? NytPizzaNummer { get; set; }
        [BindProperty]
        [Required(ErrorMessage ="Der skal v�re et navn")]
        [StringLength(1000, MinimumLength = 2, ErrorMessage = "Der skal v�re mindst to tegn i et navn")]
        public string NytPizzaNavn { get; set; }
        [BindProperty]
        public string NytPizzaBeskrivelse { get; set; }
        [BindProperty]
        [Required(ErrorMessage = "Der skal v�re en pris")]
        public double NytPizzaPris { get; set; }
        [BindProperty]
        public bool NytPizzaVegan { get; set; }
        [BindProperty]
        public bool NytPizzaDeepPan { get; set; }
        [BindProperty]
        public bool NytPizzaFamilie { get; set; }


        public void OnGet()
        { 
            


        }

        public IActionResult OnPost()
        {
            if ( !ModelState.IsValid)
            {
                return Page();
            }
            Pizza nyPizza = new Pizza ((int) NytPizzaNummer, NytPizzaNavn, NytPizzaBeskrivelse, (double) NytPizzaPris, NytPizzaVegan, NytPizzaDeepPan, NytPizzaFamilie);

           // PizzaRepository repo = new PizzaRepository(true);
            _repo.Tilf�j(nyPizza);

            return RedirectToPage("index");
        }

    }
}
