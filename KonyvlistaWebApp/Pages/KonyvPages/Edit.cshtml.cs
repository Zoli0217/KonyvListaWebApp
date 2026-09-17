using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KonyvlistaWebApp.Models;
using KonyvlistaWebApp.Data;

namespace KonyvlistaWebApp.Pages.KonyvPages;

public class EditModel : PageModel
{
    private readonly KonyvtarDbContext _context;

    public EditModel(KonyvtarDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Konyv Konyv { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var konyv = await _context.Konyvek.FirstOrDefaultAsync(m => m.Id == id);
        if (konyv is null)
        {
            return NotFound();
        }
        Konyv = konyv;
        return Page();
    }

    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Attach(Konyv).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!KonyvExists(Konyv.Id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return RedirectToPage("./Index");
    }

    private bool KonyvExists(int id)
    {
        return _context.Konyvek.Any(e => e.Id == id);
    }
}
