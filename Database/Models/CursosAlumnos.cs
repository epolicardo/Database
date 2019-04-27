using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Database.Models
{
	public class CursosAlumnos
	{

		public int AlumnoId { get; set; }
		public int CursoId { get; set; }
		public Alumno Alumno { get; set; }
		public Curso Curso { get; set; }
	}
}
