using Microsoft.EntityFrameworkCore;
using proyectoEF.Modelo;
namespace proyectoEF.Context{
    public class TareasContext : DbContext{
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Tarea> Tareas { get; set; }
        public TareasContext(DbContextOptions<TareasContext> options) :base(options) { }
    }
}
