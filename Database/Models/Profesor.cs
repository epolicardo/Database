﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database.Models
{
	public class Profesor: Persona
	{
		public int Id { get; set; }
		public List<Curso> Cursos { get; set; }
	}
}
