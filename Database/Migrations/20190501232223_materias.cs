using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class materias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Materia",
                table: "Curso");

            migrationBuilder.AddColumn<int>(
                name: "MateriaId",
                table: "Curso",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Materias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materias", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Curso_MateriaId",
                table: "Curso",
                column: "MateriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Curso_Materias_MateriaId",
                table: "Curso",
                column: "MateriaId",
                principalTable: "Materias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Curso_Materias_MateriaId",
                table: "Curso");

            migrationBuilder.DropTable(
                name: "Materias");

            migrationBuilder.DropIndex(
                name: "IX_Curso_MateriaId",
                table: "Curso");

            migrationBuilder.DropColumn(
                name: "MateriaId",
                table: "Curso");

            migrationBuilder.AddColumn<string>(
                name: "Materia",
                table: "Curso",
                nullable: true);
        }
    }
}
