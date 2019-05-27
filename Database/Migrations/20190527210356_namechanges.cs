using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class namechanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asistencias_Cursos_CursoId",
                table: "Asistencias");

            migrationBuilder.DropForeignKey(
                name: "FK_CursosAlumnos_Cursos_CursoIdId",
                table: "CursosAlumnos");

            migrationBuilder.DropForeignKey(
                name: "FK_Notas_Cursos_CursoId",
                table: "Notas");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.RenameColumn(
                name: "CursoId",
                table: "Notas",
                newName: "AulaId");

            migrationBuilder.RenameIndex(
                name: "IX_Notas_CursoId",
                table: "Notas",
                newName: "IX_Notas_AulaId");

            migrationBuilder.RenameColumn(
                name: "CursoId",
                table: "Asistencias",
                newName: "AulaId");

            migrationBuilder.RenameIndex(
                name: "IX_Asistencias_CursoId",
                table: "Asistencias",
                newName: "IX_Asistencias_AulaId");

            migrationBuilder.CreateTable(
                name: "Aulas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MateriaId = table.Column<int>(nullable: true),
                    ProfesorId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aulas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aulas_Materias_MateriaId",
                        column: x => x.MateriaId,
                        principalTable: "Materias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Aulas_Usuarios_ProfesorId",
                        column: x => x.ProfesorId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aulas_MateriaId",
                table: "Aulas",
                column: "MateriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Aulas_ProfesorId",
                table: "Aulas",
                column: "ProfesorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Asistencias_Aulas_AulaId",
                table: "Asistencias",
                column: "AulaId",
                principalTable: "Aulas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CursosAlumnos_Aulas_CursoIdId",
                table: "CursosAlumnos",
                column: "CursoIdId",
                principalTable: "Aulas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Notas_Aulas_AulaId",
                table: "Notas",
                column: "AulaId",
                principalTable: "Aulas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asistencias_Aulas_AulaId",
                table: "Asistencias");

            migrationBuilder.DropForeignKey(
                name: "FK_CursosAlumnos_Aulas_CursoIdId",
                table: "CursosAlumnos");

            migrationBuilder.DropForeignKey(
                name: "FK_Notas_Aulas_AulaId",
                table: "Notas");

            migrationBuilder.DropTable(
                name: "Aulas");

            migrationBuilder.RenameColumn(
                name: "AulaId",
                table: "Notas",
                newName: "CursoId");

            migrationBuilder.RenameIndex(
                name: "IX_Notas_AulaId",
                table: "Notas",
                newName: "IX_Notas_CursoId");

            migrationBuilder.RenameColumn(
                name: "AulaId",
                table: "Asistencias",
                newName: "CursoId");

            migrationBuilder.RenameIndex(
                name: "IX_Asistencias_AulaId",
                table: "Asistencias",
                newName: "IX_Asistencias_CursoId");

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MateriaId = table.Column<int>(nullable: true),
                    ProfesorId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cursos_Materias_MateriaId",
                        column: x => x.MateriaId,
                        principalTable: "Materias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cursos_Usuarios_ProfesorId",
                        column: x => x.ProfesorId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_MateriaId",
                table: "Cursos",
                column: "MateriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_ProfesorId",
                table: "Cursos",
                column: "ProfesorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Asistencias_Cursos_CursoId",
                table: "Asistencias",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CursosAlumnos_Cursos_CursoIdId",
                table: "CursosAlumnos",
                column: "CursoIdId",
                principalTable: "Cursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Notas_Cursos_CursoId",
                table: "Notas",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
