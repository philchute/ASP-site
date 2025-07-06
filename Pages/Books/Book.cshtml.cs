using Microsoft.AspNetCore.Mvc.RazorPages;
using ASP_site.Models;
using ASP_site.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;

namespace ASP_site.Pages.Books
{
  public class BookModel : PageModel
  {
    private readonly GameContext _context;
    public BookModel(GameContext context)
    {
      _context = context;
    }

    public Book? Book { get; set; }
    public List<Link> BookLinks { get; set; } = new List<Link>();

    public async Task OnGetAsync(string BookTitle)
    {
      Book = await _context.Books
        .Include(b => b.Tags)
        .FirstOrDefaultAsync(b => b.Title == BookTitle);

      if (Book != null)
      {
          BookLinks = await _context.Links
              .Where(l => l.BookTitle == BookTitle)
              .ToListAsync();
      }
    }
  }
} 