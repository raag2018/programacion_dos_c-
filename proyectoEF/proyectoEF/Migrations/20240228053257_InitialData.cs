using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace proyectoEF.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tarea",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "CategoriaId", "Descripcion", "Nombre", "Peso" },
                values: new object[,]
                {
                    { new Guid("720f08a5-0b57-488a-af5f-8913c8535da6"), "Actividades Pendientes de realizar", "Actividades Pendientes", 20 },
                    { new Guid("f0a66bcd-8a6a-4ba3-a77b-fd87987132b4"), "Actividades personales a realizar", "Actividades Personales", 20 }
                });

            migrationBuilder.InsertData(
                table: "Tarea",
                columns: new[] { "TareaId", "CategoriaId", "Descripcion", "Estado", "FechaCreacion", "Prioridad", "Titulo" },
                values: new object[,]
                {
                    { new Guid("0d24f6be-ad17-4d7c-87f1-1e5950838680"), new Guid("f0a66bcd-8a6a-4ba3-a77b-fd87987132b4"), null, true, new DateTime(2024, 2, 27, 23, 32, 57, 21, DateTimeKind.Local).AddTicks(6496), 0, "Tareas Personales" },
                    { new Guid("369b68d6-e4b6-48c2-a232-7cf6f8bd736c"), new Guid("720f08a5-0b57-488a-af5f-8913c8535da6"), null, true, new DateTime(2024, 2, 27, 23, 32, 57, 21, DateTimeKind.Local).AddTicks(6483), 1, "Tareas Pendientes" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("0d24f6be-ad17-4d7c-87f1-1e5950838680"));

            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("369b68d6-e4b6-48c2-a232-7cf6f8bd736c"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("720f08a5-0b57-488a-af5f-8913c8535da6"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("f0a66bcd-8a6a-4ba3-a77b-fd87987132b4"));

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tarea",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
