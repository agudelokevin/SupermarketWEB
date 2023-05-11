using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SupermarketWEB.Data;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.PayModes
{
    public class DeleteModel : PageModel
    {
        private readonly SumpermarketContext _context;
        public DeleteModel(SumpermarketContext context)
        {
            _context = context;
        }
        [BindProperty]
        public PayMode PayMode { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.PayModes == null)
            {
                return NotFound();
            }
            var payMode = await _context.PayModes.FindAsync(id);

            if (payMode != null)
            {
                PayMode = payMode;
                _context.PayModes.Remove(payMode);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
