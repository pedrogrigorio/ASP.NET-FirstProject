using FirstProject.Model;
using Microsoft.EntityFrameworkCore;

namespace FirstProject.Infra
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(
              "Server=localhost;" +
              "Port=5432;Database=company;" +
              "User Id=postgres;" +
              "Password=root;");
    }
}
