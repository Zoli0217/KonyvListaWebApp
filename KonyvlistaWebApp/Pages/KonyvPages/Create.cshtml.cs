using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KonyvlistaWebApp.Models;
using KonyvlistaWebApp.Data;

namespace KonyvlistaWebApp.Pages.KonyvPages;

public class CreateModel : PageModel
{
    private readonly KonyvtarDbContext _context;

    public CreateModel(KonyvtarDbContext context)
    {
        _context = context;
    }

    public IActionResult OnGet()
    {
        return Page();
    }

    [BindProperty]
    public Konyv Konyv { get; set; } = default!;

    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Konyvek.Add(Konyv);
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}
