using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KonyvlistaWebApp.Models;
using KonyvlistaWebApp.Data;

namespace KonyvlistaWebApp.Pages.KonyvPages;

public class IndexModel : PageModel
{
    private readonly KonyvtarDbContext _context;

    public IndexModel(KonyvtarDbContext context)
    {
        _context = context;
    }

    public IList<Konyv> Konyvek { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Konyvek = await _context.Konyvek.OrderByDescending(k => k.Id).ToListAsync();
    }
}
