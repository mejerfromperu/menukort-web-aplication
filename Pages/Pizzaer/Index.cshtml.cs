using menukort.model;
using menukort.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;

namespace menukort.Pages.Pizzaer
{
    public class IndexModel : PageModel
    {
        // instans af pizza repository
        private PizzaRepository _repo;

        // Dependency Injection
        public IndexModel(PizzaRepository repository)
        {
            _repo = repository;
        }



        // proberty til View´et
        public List<Pizza> Pizza { get; set; }

        public void OnGet()
        {
            //PizzaRepository repo = new PizzaRepository(true);

            Pizza = _repo.HentAllePizza();

        }

        public IActionResult OnPost()
        {
            return RedirectToPage("OpretPizza");
        }


    }
}
