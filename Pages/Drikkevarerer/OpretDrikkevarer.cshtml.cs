using menukort.model;
using menukort.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace menukort.Pages.Drikkevarerer
{
    public class OpretDrikkevarerModel : PageModel
    {
        private IDrikkevarerRepository _repo;

        public OpretDrikkevarerModel(IDrikkevarerRepository repo)
        {
            _repo = repo;
        }


        [BindProperty]
        public int NytDrikkevarerNummer { get; set; }
        [BindProperty]
        [Required(ErrorMessage = "Der skal v�re et navn")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Der skal v�re mindst to tegn i et navn")]
        public string NytDrikkevarerNavn { get; set; }
        [BindProperty]
        public string NytDrikkevarerStørrelse { get; set; }
        [BindProperty]
        public double NytDrikkevarerPris { get; set; }
        [BindProperty]
        public bool NytDrikkevarerAlkohol { get; set; }

        public void OnGet()
        {



        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Drikkevarer nyDrikkevarer = new Drikkevarer (NytDrikkevarerNummer, NytDrikkevarerNavn, NytDrikkevarerStørrelse, NytDrikkevarerPris, NytDrikkevarerAlkohol);

            // DrikkevarerRepository repo = new DrikkevarerRepository(true);
            _repo.Tilføj(nyDrikkevarer);

            return RedirectToPage("index");
        }

    }
}

