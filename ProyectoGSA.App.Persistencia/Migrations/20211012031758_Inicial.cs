using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoGSA.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Docente",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    identificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    profesion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    salario = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docente", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    identificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    acudidoid = table.Column<int>(type: "int", nullable: true),
                    nacimiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    padreid = table.Column<int>(type: "int", nullable: true),
                    madreid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.id);
                    table.ForeignKey(
                        name: "FK_Persona_Persona_acudidoid",
                        column: x => x.acudidoid,
                        principalTable: "Persona",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persona_Persona_madreid",
                        column: x => x.madreid,
                        principalTable: "Persona",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persona_Persona_padreid",
                        column: x => x.padreid,
                        principalTable: "Persona",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persona_acudidoid",
                table: "Persona",
                column: "acudidoid");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_madreid",
                table: "Persona",
                column: "madreid");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_padreid",
                table: "Persona",
                column: "padreid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Docente");

            migrationBuilder.DropTable(
                name: "Persona");
        }
    }
}
