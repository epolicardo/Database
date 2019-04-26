using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Database.Models
{
	public class Asistencia
	{
		[Key]
		public int Id { get; set; }
		public DateTime Fecha { get; set; }
		public Curso Curso { get; set; }
		public Alumno Alumno { get; set; }

	}
}
