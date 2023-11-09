using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesBookStore.Models;

namespace RazorPagesBookStore.Data
{
    public class RazorPagesBookStoreContext : DbContext
    {
        public RazorPagesBookStoreContext (DbContextOptions<RazorPagesBookStoreContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesBookStore.Models.Book> Book { get; set; } = default!;
    }
}
