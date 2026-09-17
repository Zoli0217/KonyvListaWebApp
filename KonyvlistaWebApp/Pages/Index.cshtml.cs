using KonyvlistaWebApp.Data;
using KonyvlistaWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KonyvlistaWebApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    protected readonly KonyvtarDbContext _context;

    public IndexModel(KonyvtarDbContext context)
    {
        _context = context;
    }

    public IList<Konyv> Konyvek { get; set; }

    public void OnGet()
    {
        Konyvek = _context.Konyvek.ToList();
    }
}