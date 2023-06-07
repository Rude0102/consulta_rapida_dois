using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace consulta_rapida.Migrations
{
    public partial class Paciente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nomePaciente = table.Column<string>(type: "TEXT", nullable: true),
                    horaConsulta = table.Column<DateTime>(type: "TEXT", nullable: false),
                    especialidade = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paciente");
        }
    }
}
