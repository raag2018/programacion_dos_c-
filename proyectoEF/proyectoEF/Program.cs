using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using proyectoEF.Context;
var builder = WebApplication.CreateBuilder(args);
// Registra el contexto de la base de datos usando SQL Server
builder.Services.AddDbContext<TareasContext>(options =>
    options.UseSqlServer(@"Data Source=ROBERT\UNAB;Initial Catalog=TareasDb;User ID=sa;Password=unab;TrustServerCertificate=True"));
var app = builder.Build();
app.MapGet("/", () => "Hello World!");
app.MapGet("/dbconexion", async ([FromServices] TareasContext dbContext) =>
{
    // Asegura que la base de datos esté creada
    dbContext.Database.EnsureCreated();
    return Results.Ok("Base de datos creada con éxito");
});
app.Run();