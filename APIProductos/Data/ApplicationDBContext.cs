using APIProductos.Models;
using Microsoft.EntityFrameworkCore;

namespace APIProductos.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(
           
            DbContextOptions<ApplicationDBContext> options ) : base( options ) { }
            
        public DbSet<Producto> Productos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>().HasData(
                new Producto
                {
                    IdProducto = 100,
                    Nombre="Producto1",
                    Descripcion="Descipcion Producto1",
                    Cantidad=12
                });
        }
    }
}
