namespace Database.Models
{

using System.Collections.Generic;

    public class Profesores : Usuarios
	{
		public List<Aulas> Aulas { get; set; }
	}
}
