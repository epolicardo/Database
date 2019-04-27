﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database.Models
{
	public class Profesor
	{
		public int Id { get; set; }
		public string Apellido { get; set; }
		public string Nombre { get; set; }
		public List<Curso> Cursos { get; set; }
	}
}
