using APIProductos.Models;
using Microsoft.EntityFrameworkCore;

namespace APIProductos.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(
           
            DbContextOptions<ApplicationDBContext> options ) : base( options ) { }
            
        DbSet<Producto> Productos { get; set; }
    }
}
