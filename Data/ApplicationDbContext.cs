using Microsoft.EntityFrameworkCore;
using SweetDelights.Models;

namespace SweetDelights.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cake> Cakes { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
