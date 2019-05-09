namespace Database.Models
{

using System.Collections.Generic;

    public class Profesores : Usuarios
	{
		public List<Cursos> Cursos { get; set; }
	}
}
