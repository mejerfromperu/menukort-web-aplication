using menukort.model;
using menukort.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;

namespace menukort.Pages.Burgere
{
    public class IndexModel : PageModel
    {
        // instans af burger repository
        private IBurgerRepository _repo;

        // 
        public IndexModel(IBurgerRepository repository)
        {
            _repo = repository;
        }



        // proberty til View´et
        public List<Burger> Burger { get; set; }

        public void OnGet()
        {
            //BurgerRepository repo = new BurgerRepository(true);

            Burger = _repo.HentAlleBurger();

        }
        public IActionResult OnPost()
        {
            return RedirectToPage("OpretBurger");
        }
    }
}