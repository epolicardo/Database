namespace Database.Models
{

    using System;

    public class Notas
	{
		public int Id { get; set; }
		public Cursos Curso { get; set; }
		public decimal Calificacion { get; set; }
		public Alumnos Alumno { get; set; }
		public DateTime Fecha { get; set; }

	}
}
