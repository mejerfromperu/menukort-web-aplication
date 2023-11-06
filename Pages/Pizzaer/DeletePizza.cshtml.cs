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
            _repo.Slet(nummer);

            return RedirectToPage("Index");
        }

        public IActionResult OnPost(int nummer)
        {
            _repo.Slet(nummer);

            return RedirectToPage("Index");
        }

        public IActionResult OnPostCancel(int nummer)
        {
            _repo.Slet(nummer);

            return RedirectToPage("Index");
        }


    }
}
