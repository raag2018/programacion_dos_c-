using Microsoft.EntityFrameworkCore;
using proyectoEF.Modelo;
namespace proyectoEF.Context{
    public class TareasContext : DbContext{
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Tarea> Tareas { get; set; }
        public TareasContext(DbContextOptions<TareasContext> options) :base(options) { }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            List<Categoria> categoriaInit = new List<Categoria>();
            categoriaInit.Add(new Categoria()
            {
                CategoriaId = Guid.Parse("720f08a5-0b57-488a-af5f-8913c8535da6"),
                Nombre = "Actividades Pendientes",
                Descripcion = "Actividades Pendientes de realizar",
                Peso = 20
            });
            categoriaInit.Add(new Categoria()
            {
                CategoriaId = Guid.Parse("f0a66bcd-8a6a-4ba3-a77b-fd87987132b4"),
                Nombre = "Actividades Personales",
                Descripcion = "Actividades personales a realizar",
                Peso = 20
            });

            modelBuilder.Entity<Categoria>(categoria =>
            {
                categoria.ToTable("Categoria");
                categoria.HasKey(p => p.CategoriaId);
                categoria.Property(p => p.Nombre).IsRequired().HasMaxLength(150);
                categoria.Property(p => p.Descripcion).IsRequired(false);
                categoria.Property(p => p.Peso);
                categoria.HasData(categoriaInit);
            });
            List<Tarea> tareasInit = new List<Tarea>();
            tareasInit.Add(new Tarea()
            {
                TareaId = Guid.Parse("369b68d6-e4b6-48c2-a232-7cf6f8bd736c"),
                CategoriaId = Guid.Parse("720f08a5-0b57-488a-af5f-8913c8535da6"),
                Prioridad = Prioridad.Media,
                Titulo = "Tareas Pendientes",
                FechaCreacion = DateTime.Now,
                Estado = true
            });
            tareasInit.Add(new Tarea()
            {
                TareaId = Guid.Parse("0d24f6be-ad17-4d7c-87f1-1e5950838680"),
                CategoriaId = Guid.Parse("f0a66bcd-8a6a-4ba3-a77b-fd87987132b4"),
                Prioridad = Prioridad.Baja,
                Titulo = "Tareas Personales",
                FechaCreacion = DateTime.Now,
                Estado = true
            });
            modelBuilder.Entity<Tarea>(tarea =>
            {
                tarea.ToTable("Tarea");
                tarea.HasKey(p => p.TareaId);
                tarea.HasOne(p => p.Categoria)
                .WithMany(p => p.Tareas)
                .HasForeignKey(p => p.CategoriaId);
                tarea.Property(p => p.Titulo)
                .IsRequired().HasMaxLength(200);
                tarea.Property(p => p.Descripcion).IsRequired(false);
                tarea.Property(p => p.Prioridad);
                tarea.Property(p => p.FechaCreacion);
                tarea.Ignore(p => p.Resumen);
                tarea.Property(p => p.Estado);
                tarea.HasData(tareasInit);
            });
        }
    }
}
