using menukort.model;
using menukort.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace menukort.Pages.Drikkevarerer
{
    public class DeleteDrikkeVarerModel : PageModel
    {

        private IDrikkevarerRepository _repo;


        public DeleteDrikkeVarerModel(IDrikkevarerRepository repo)
        {
            _repo = repo;
        }

        public Drikkevarer Drikkevarer { get; private set; }


        public IActionResult OnGet(int nummer)
        {
            Drikkevarer = _repo.HentDrikkevarer(nummer);


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
