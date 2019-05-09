//Clase que representa el mensaje generado en una conversación.

namespace Database.Models
{

    using System;

    public class Mensajes
	{
		public int Id { get; set; }
		public DateTime FechaEnviado { get; set; }
        public string CuerpoMensaje { get; set; }
        public Usuarios Emisor { get; set; }
        public Salas IdSala { get; set; }

	}
}
