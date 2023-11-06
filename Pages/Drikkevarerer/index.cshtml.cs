using menukort.model;
using menukort.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;

namespace menukort.Pages.Drikkevarerer
{
    public class DrikkevarerModel : PageModel
    {
        // instans af Drikkevarer repository
        private DrikkevarerRepository _repo;

        // 
        public DrikkevarerModel(DrikkevarerRepository repository)
        {
            _repo = repository;
        }



        // proberty til View´et
        public List<Drikkevarer> Drikkevarer { get; set; }

        public void OnGet()
        {
            //DrikkevarerRepository repo = new DrikkevarerRepository(true);

            Drikkevarer = _repo.HentAlleDrikkevarer();

        }

        public IActionResult OnPost()
        {
            return RedirectToPage("OpretDrikkevarer");

        }
    }
}
