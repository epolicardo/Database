using Database.ModelsData;
using System.Collections.Generic;

namespace Database.Models
{
	public class Curso
	{
		public int Id { get; set; }
		public Materia Materia { get; set; }
		public Profesor Profesor { get; set; }


	}
}