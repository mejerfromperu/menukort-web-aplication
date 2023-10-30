using menukort.model;
using menukort.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;

namespace menukort.Pages.Pizzaer
{
    public class IndexModel : PageModel
    {

        public List<Pizza> Pizza { get; set; }

        public void OnGet()
        {
            PizzaRepository repo = new PizzaRepository(true);

            Pizza = repo.HentAllePizza();

        }
    }
}
