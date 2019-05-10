using Database.ModelsData;
using Microsoft.EntityFrameworkCore;
using System;

namespace Database.Models
{
	public class DataContext : DbContext
	{
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<CursosAlumnos>()
				.HasKey(c => new {c.AlumnoId, c.CursoId });
		}

		public DataContext(DbContextOptions<DataContext> options):base(options)
		{
			
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//colocar conexion string de la bd
			//optionsBuilder.UseSqlServer(Env.dbstring);
		

		}

        public DbSet<Personas> Personas { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Alumnos> Alumnos { get; set; }
        public DbSet<Profesores> Profesores { get; set; }
        public DbSet<Cursos> Cursos { get; set; }
        public DbSet<Salas> Salas { get; set; }
        public DbSet<Asistencias> Asistencias { get; set; }
        public DbSet<Archivos> Archivos { get; set; }
        public DbSet<Notas> Notas { get; set; }
        public DbSet<CursosAlumnos> CursosAlumnos { get; set; }
        public DbSet<Materias> Materias { get; set; }
        public DbSet<Mensajes> Mensajes { get; set; }
        public DbSet<Barrios> Barrios { get; set; }
        public DbSet<Localidades> Localidades { get; set; }
        public DbSet<Domicilios> Domicilios { get; set; }

    }
}
