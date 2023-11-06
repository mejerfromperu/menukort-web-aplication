using menukort.model;
using menukort.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace menukort.Pages.Pizzaer
{
    public class DeletePizzaModel : PageModel
    {

        private IPizzaRepository _repo;


        public DeletePizzaModel(IPizzaRepository repo)
        {
            _repo = repo;
        }

        public Pizza Pizza { get; private set; }


        public IActionResult OnGet(int nummer)
        {
            Pizza = _repo.HentPizza(nummer);


            return Page();
        }

        public IActionResult OnPostDelete(int nummer)
        {
            _repo.Slet(nummer);

            return RedirectToPage("Index");
        }

        public IActionResult OnPostFortryd(int nummer)
        {
            return RedirectToPage("Index");
        }


    }
}
