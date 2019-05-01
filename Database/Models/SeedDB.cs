using Database.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Database
{
	internal class SeedDB
	{
		private readonly ContextDb context;
		private Random random;
		public SeedDB(ContextDb context)
		{
			this.context = context;
			this.random = new Random();

		}

		public async Task SeedAsync() {
			await context.Database.EnsureCreatedAsync();
			string[] nombres = { "Jose", "Rodrigo", "Martin", "Juan" };
			string[] apellidos = { "Martinez", "Rodriguez", "Perez", "Diaz" };
			if (!context.Alumno.Any())
			{
				AlumnoAdd(nombres[random.Next(0, 3)],"sdfsdfsf@", apellidos[random.Next(0, 3)]);
				AlumnoAdd(nombres[random.Next(0, 3)], "sdfsdfsf@", apellidos[random.Next(0, 3)]);
				AlumnoAdd(nombres[random.Next(0, 3)], "sdfsdfsf@", apellidos[random.Next(0, 3)]);
				AlumnoAdd(nombres[random.Next(0, 3)], "sdfsdfsf@", apellidos[random.Next(0, 3)]);
				AlumnoAdd(nombres[random.Next(0, 3)], "sdfsdfsf@", apellidos[random.Next(0, 3)]);
				await context.SaveChangesAsync();
			}
		}

		private void AlumnoAdd(string apellido, string email, string nombre)
		{
			context.Alumno.Add(new Alumno
			{
				Apellido = apellido,
				Email = email,
				Nombre = nombre,
			
			});
		}
	}
}