using BulkyBooksWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBooksWeb.Data
{
    public class ApplicationdbContext : DbContext
    {
        public ApplicationdbContext(DbContextOptions<ApplicationdbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
