using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesBookStore.Data;
using RazorPagesBookStore.Models;

namespace RazorPagesBookStore.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesBookStore.Data.RazorPagesBookStoreContext _context;

        public IndexModel(RazorPagesBookStore.Data.RazorPagesBookStoreContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book.ToListAsync();
            }
        }
    }
}
