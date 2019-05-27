namespace Database.Models
{

    using System;
	using System.ComponentModel.DataAnnotations;

	public class Notas
	{
		public int Id { get; set; }
		public Aula Aula { get; set; }

		public decimal Calificacion { get; set; }

		public Alumnos Alumno { get; set; }
		public DateTime Fecha { get; set; }

	}
}
