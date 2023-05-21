using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.Account
{
    public class RegistroModel : PageModel
    {
        private readonly SumpermarketContext _context;
        public RegistroModel(SumpermarketContext context)
        {
            _context = context;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Registro Registro { get; set; } = default!;
        public async Task<IActionResult> OnPostAsync()
        {
            
                if (!ModelState.IsValid || _context.Registros == null || Registro == null)
            {
                return Page();
            }
            _context.Registros.Add(Registro);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Account/Login");
        }
       
    }
}
