using Microsoft.EntityFrameworkCore;

namespace coreFirstCRUDApplication.Models
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-75O0631G;Database=CRUDAppDB;Integrated Security=true;TrustServerCertificate=true;");
        }
    }
}
