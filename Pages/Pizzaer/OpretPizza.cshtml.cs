using menukort.model;
using menukort.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography.X509Certificates;

namespace menukort.Pages.Pizzaer
{
    public class OpretPizzaModel : PageModel
    {
        [BindProperty]
        public int NytPizzaNummer { get; set; }
        [BindProperty]

        public string NytPizzaNavn { get; set; }
        [BindProperty]

        public string NytPizzaBeskrivelse { get; set; }
        [BindProperty]
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

        public void OnPost()
        {
            Pizza nyPizza = new Pizza(NytPizzaNummer, NytPizzaNavn, NytPizzaBeskrivelse, NytPizzaPris, NytPizzaVegan, NytPizzaDeepPan, NytPizzaFamilie);

            PizzaRepository repo = new PizzaRepository(true);
            repo.Tilføj(nyPizza);


        }

    }
}
