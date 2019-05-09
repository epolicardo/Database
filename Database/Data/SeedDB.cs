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
			if (!context.Personas.Any())
			{
				PersonasAdd(nombres[random.Next(0, 3)], apellidos[random.Next(0, 3)]);
                PersonasAdd(nombres[random.Next(0, 3)], apellidos[random.Next(0, 3)]);
                PersonasAdd(nombres[random.Next(0, 3)], apellidos[random.Next(0, 3)]);
                PersonasAdd(nombres[random.Next(0, 3)], apellidos[random.Next(0, 3)]);
                PersonasAdd(nombres[random.Next(0, 3)], apellidos[random.Next(0, 3)]);
				await context.SaveChangesAsync();
			}
		}

		private void PersonasAdd(string nombre, string apellido)
		{
			context.Personas.Add(new Personas
			{
				Apellido = apellido,
				Nombre = nombre,
			
			});
		}
	}
}