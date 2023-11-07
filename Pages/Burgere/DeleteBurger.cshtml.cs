using menukort.model;
using menukort.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace menukort.Pages.Burgere
{
    public class DeleteBurgerModel : PageModel
    {

        private IBurgerRepository _repo;


        public DeleteBurgerModel(IBurgerRepository repo)
        {
            _repo = repo;
        }

        public Burger Burger { get; private set; }


        public IActionResult OnGet(int nummer)
        {
            Burger = _repo.HentBurger(nummer);


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
