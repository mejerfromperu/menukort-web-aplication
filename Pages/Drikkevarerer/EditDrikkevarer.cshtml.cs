using menukort.model;
using menukort.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace menukort.Pages.Drikkevarerer
{
        public class EditDrikkevarerModel : PageModel
        {
            private IDrikkevarerRepository _repo;

            public EditDrikkevarerModel(IDrikkevarerRepository repo)
            {
                _repo = repo;
            }

            [BindProperty]
            [Required(ErrorMessage = "Der skal v�re et nummer")]
            public int? NytDrikkevarerNummer { get; set; }


            [BindProperty]
            [Required(ErrorMessage = "Der skal v�re et navn")]
            [StringLength(1000, MinimumLength = 2, ErrorMessage = "Der skal v�re mindst to tegn i et navn")]
            public string NytDrikkevarerNavn { get; set; }


            [BindProperty]
            public string NytDrikkevarerStørrelse { get; set; }


            [BindProperty]
            [Required(ErrorMessage = "Der skal v�re en pris")]
            public double NytDrikkevarerPris { get; set; }


            [BindProperty]
            public bool NytDrikkevarerAlkohol { get; set; }


            public void OnGet(int nummer)
            {
                Drikkevarer drikkevarer = _repo.HentDrikkevarer(nummer);

                NytDrikkevarerNummer = drikkevarer.Nummer;
                NytDrikkevarerNavn = drikkevarer.Navn;
                NytDrikkevarerStørrelse = drikkevarer.Størrelse;
                NytDrikkevarerPris = drikkevarer.Pris;
                NytDrikkevarerAlkohol = drikkevarer.Alkohol;
            }
            public IActionResult OnPostChange()
            {
                if (!ModelState.IsValid)
                {
                    return Page();
                }

                Drikkevarer drikkevarer = _repo.HentDrikkevarer(NytDrikkevarerNummer ?? 0);

                drikkevarer.Navn = NytDrikkevarerNavn;
                drikkevarer.Størrelse = NytDrikkevarerStørrelse;
                drikkevarer.Pris = NytDrikkevarerPris;
                drikkevarer.Alkohol = NytDrikkevarerAlkohol;

                return RedirectToPage("Index");
            }

            public IActionResult OnPostCancel()
            {
                return RedirectToPage("Index");
            }
        }
}
