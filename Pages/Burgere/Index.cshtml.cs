using menukort.model;
using menukort.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;

namespace menukort.Pages.Burgere
{
    public class IndexModel : PageModel
    {

        public List<Burger> Burger { get; set; }

        public void OnGet()
        {
            BurgerRepository repo = new BurgerRepository(true);

            Burger = repo.HentAlleBurger();

        }
        public IActionResult OnPost()
        {
            return RedirectToPage("OpretBurger");
        }
    }
}