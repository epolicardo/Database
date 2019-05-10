//namespace Database
//{

//    using System;
//    using System.Linq;
//    using System.Threading.Tasks;
//    using Database.Helpers;
//    using Database.Models;

//    internal class SeedDB
//    {
//        private readonly DataContext context;
//        private readonly IUserHelper userHelper;
//        private Random random;


//        public SeedDB(DataContext context, IUserHelper userHelper)
//        {
//            this.context = context;
//            this.userHelper = userHelper;
//            this.random = new Random();

//        }

//        public async Task SeedAsync()
//        {


//            await context.Database.EnsureCreatedAsync();

//            //Add User

//            var usuario = await this.userHelper.AddUsuarioAsync(new Personas => )

//            string[] nombres = { "Jose", "Rodrigo", "Martin", "Juan" };
//            string[] apellidos = { "Martinez", "Rodriguez", "Perez", "Diaz" };
//            if (!context.Personas.Any())
//            {
//                PersonasAdd(nombres[random.Next(0, 3)], apellidos[random.Next(0, 3)]);
//                PersonasAdd(nombres[random.Next(0, 3)], apellidos[random.Next(0, 3)]);
//                PersonasAdd(nombres[random.Next(0, 3)], apellidos[random.Next(0, 3)]);
//                PersonasAdd(nombres[random.Next(0, 3)], apellidos[random.Next(0, 3)]);
//                PersonasAdd(nombres[random.Next(0, 3)], apellidos[random.Next(0, 3)]);
//                await context.SaveChangesAsync();
//            }
//        }

//        private void PersonasAdd(string nombre, string apellido)
//        {
//            context.Personas.Add(new Personas
//            {
//                Apellido = apellido,
//                Nombre = nombre,
//            });
//        }
//    }
//}




