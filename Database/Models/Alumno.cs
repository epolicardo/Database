using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Database.Models
{
	public class Alumno: Persona
	{
		public int Id { get; set; }
		public List<CursosAlumnos> CursosAlumnos { get; set; }

	}
}
