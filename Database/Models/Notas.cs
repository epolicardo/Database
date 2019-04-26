using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database.Models
{
	public class Notas
	{
		public int Id { get; set; }
		public Curso Curso { get; set; }
		public int Calificacion { get; set; }
		public Alumno Alumno { get; set; }

	}
}
