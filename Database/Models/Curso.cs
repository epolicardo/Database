using System.Collections.Generic;

namespace Database.Models
{
	public class Curso
	{
		public int Id { get; set; }
		public string Materia { get; set; }
		public Profesor Profesor { get; set; }
		public List<CursosAlumnos> CursosAlumnos { get; set; }

	}
}