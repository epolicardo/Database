namespace Database.Models
{

using System;

    public class Personas
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		public string Apellido { get; set; }
		//Ej. 1 - DNI / 2 - Pasaporte / 3 - LE
		public int TipoDocumento { get; set; }
		public string Documento { get; set; }
        public int Genero { get; set; }
		public string Domicilio { get; set; }
		public string TelefonoFijo { get; set; }
		public DateTime FechaNacimiento { get; set; }
        public string LugarNacimiento { get; set; }
     }
}
