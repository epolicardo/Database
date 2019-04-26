using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class Cursonotasarchivos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdCurso",
                table: "Profesor");

            migrationBuilder.DropColumn(
                name: "IdAlumno",
                table: "Asistencia");

            migrationBuilder.DropColumn(
                name: "IdCanal",
                table: "Asistencia");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Alumno",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "AlumnoId",
                table: "Asistencia",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CursoId",
                table: "Asistencia",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Archivos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ruta = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Archivos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Materia = table.Column<string>(nullable: true),
                    AlumnoId = table.Column<int>(nullable: true),
                    ProfesorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Curso_Alumno_AlumnoId",
                        column: x => x.AlumnoId,
                        principalTable: "Alumno",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Curso_Profesor_ProfesorId",
                        column: x => x.ProfesorId,
                        principalTable: "Profesor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CursoId = table.Column<int>(nullable: true),
                    Calificacion = table.Column<int>(nullable: false),
                    AlumnoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notas_Alumno_AlumnoId",
                        column: x => x.AlumnoId,
                        principalTable: "Alumno",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notas_Curso_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Curso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asistencia_AlumnoId",
                table: "Asistencia",
                column: "AlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_Asistencia_CursoId",
                table: "Asistencia",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Curso_AlumnoId",
                table: "Curso",
                column: "AlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_Curso_ProfesorId",
                table: "Curso",
                column: "ProfesorId");

            migrationBuilder.CreateIndex(
                name: "IX_Notas_AlumnoId",
                table: "Notas",
                column: "AlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_Notas_CursoId",
                table: "Notas",
                column: "CursoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Asistencia_Alumno_AlumnoId",
                table: "Asistencia",
                column: "AlumnoId",
                principalTable: "Alumno",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Asistencia_Curso_CursoId",
                table: "Asistencia",
                column: "CursoId",
                principalTable: "Curso",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asistencia_Alumno_AlumnoId",
                table: "Asistencia");

            migrationBuilder.DropForeignKey(
                name: "FK_Asistencia_Curso_CursoId",
                table: "Asistencia");

            migrationBuilder.DropTable(
                name: "Archivos");

            migrationBuilder.DropTable(
                name: "Notas");

            migrationBuilder.DropTable(
                name: "Curso");

            migrationBuilder.DropIndex(
                name: "IX_Asistencia_AlumnoId",
                table: "Asistencia");

            migrationBuilder.DropIndex(
                name: "IX_Asistencia_CursoId",
                table: "Asistencia");

            migrationBuilder.DropColumn(
                name: "AlumnoId",
                table: "Asistencia");

            migrationBuilder.DropColumn(
                name: "CursoId",
                table: "Asistencia");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Alumno",
                newName: "ID");

            migrationBuilder.AddColumn<int>(
                name: "IdCurso",
                table: "Profesor",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdAlumno",
                table: "Asistencia",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdCanal",
                table: "Asistencia",
                nullable: false,
                defaultValue: 0);
        }
    }
}
