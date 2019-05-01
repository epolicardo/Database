using Database.ModelsData;
using Microsoft.EntityFrameworkCore;
using System;

namespace Database.Models
{
	public class ContextDb : DbContext
	{
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<CursosAlumnos>()
				.HasKey(c => new {c.AlumnoId, c.CursoId });
		}

		public ContextDb(DbContextOptions<ContextDb> options):base(options)
		{
			
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//colocar conexion string de la bd
			optionsBuilder.UseSqlServer(Env.dbstring);
		

		}

		public DbSet<Alumno> Alumno { get; set; }
		public DbSet<Profesor> Profesor { get; set; }
		public DbSet<Asistencia> Asistencia { get; set; }
		public DbSet<Curso> Curso { get; set; }
		public DbSet<Archivos> Archivos { get; set; }
		public DbSet<Notas> Notas { get; set; }
		public DbSet<CursosAlumnos> CursosAlumnos { get; set; }
		public DbSet<Materia> Materias { get; set; }

	}
}
