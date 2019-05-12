namespace Database.Models
{

    using System;
    using System.ComponentModel.DataAnnotations;

    public class Asistencias
	{
		[Key]
		public int Id { get; set; }
		public DateTime Fecha { get; set; }
		public Cursos Curso { get; set; }
		public Alumnos Alumno { get; set; }

	}
}
