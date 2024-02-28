using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using proyectoEF.Context;
using proyectoEF.Modelo;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
var builder = WebApplication.CreateBuilder(args);
// Registra el contexto de la base de datos usando SQL Server
builder.Services.AddDbContext<TareasContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("cnTareas")));
var app = builder.Build();
app.MapGet("/", () => "Hello World!");
app.MapGet("/dbconexion", async ([FromServices] TareasContext dbContext) =>
{
    // Asegura que la base de datos esté creada
    dbContext.Database.EnsureCreated();
    return Results.Ok("Base de datos creada con éxito");
});

app.MapGet("/api/tareas", async ([FromServices] TareasContext dbContext) =>
{   return Results.Ok(dbContext.Tareas);});

app.MapGet("/api/tareasPrioridadBaja", async ([FromServices] TareasContext dbContext) =>
{ 
    return Results.Ok(dbContext.Tareas
    .Where(p => p.Prioridad == proyectoEF.Modelo.Prioridad.Baja)); 
});
app.MapGet("/api/tareasPrioridadAlta", async ([FromServices] TareasContext dbContext) =>
{
    return Results.Ok(dbContext.Tareas
    .Where(p => p.Prioridad == proyectoEF.Modelo.Prioridad.Alta));
});

app.MapGet("/api/tareasConCategorias", async ([FromServices] TareasContext dbContext) =>
{
    return Results.Ok(dbContext.Tareas
        .Include(p => p.Categoria)
        .Where(p => p.Prioridad == proyectoEF.Modelo.Prioridad.Baja));
});
app.MapPost("/api/insertTarea", 
    async ([FromServices] TareasContext dbContext, [FromBody] Tarea tarea) 
    => {
        try{
            tarea.TareaId = Guid.NewGuid();
            tarea.FechaCreacion = DateTime.Now;
            await dbContext.AddAsync(tarea);
            //await dbContext.Tareas.AddAsync(tarea);
            await dbContext.SaveChangesAsync();
            return Results.Ok();
        }catch (Exception ex) {  return Results.BadRequest("Error al insertar la tarea: " + ex.Message); }
});
app.MapPut("/api/UpdateTarea/{id}",
    async ([FromServices] TareasContext dbContext, 
    [FromBody] Tarea tarea, [FromRoute] Guid id)
    => {
        try{
            var tareaActual = dbContext.Tareas.Find(id);
            if (tareaActual != null){
                tareaActual.CategoriaId = tarea.CategoriaId;
                tareaActual.Titulo = tarea.Titulo;
                tareaActual.Prioridad = tarea.Prioridad;
                tareaActual.Descripcion = tarea.Descripcion;
                await dbContext.SaveChangesAsync();
                return Results.Ok();
            }
            return Results.NotFound();
        }catch (Exception ex) { return Results.BadRequest("Error al actualizar la tarea: " + ex.Message); }
    });
app.MapDelete("/api/DeleteTarea/{id}",
    async ([FromServices] TareasContext dbContext, [FromRoute] Guid id)
    => {
        try{
            var tareaActual = dbContext.Tareas.Find(id);
            if (tareaActual != null){
                 dbContext.Remove(tareaActual);
                await dbContext.SaveChangesAsync();
                return Results.Ok();
            }
            return Results.NotFound();
        }catch (Exception ex) { return Results.BadRequest("Error al actualizar la tarea: " + ex.Message); }
    });

app.Run();