using BookServiceAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookServiceAPI.Database
{
    public class MyContext : DbContext
    {
        public DbSet<Book>? books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = DESKTOP-FA8GT7U\\SQLEXPRESS; database=BookSevice ;trusted_connection=true;TrustServerCertificate=true");
            
        }
    }
}
