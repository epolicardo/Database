
using System.Collections.Generic;
///Clase que representa las salas de chat.
namespace Database.Models
{
    public class Salas
    {
        public int Id { get; set; }
        public string NombreSala { get; set; }
        public string DescripciónSala{ get; set; }

        public List<Usuarios> ListaUsuarios { get; set; }
    }
}