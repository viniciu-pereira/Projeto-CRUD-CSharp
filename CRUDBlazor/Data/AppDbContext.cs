using CRUDBlazor.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDBlazor.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Empresa> Empresas { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options) 
        { 
        }
    }
}
