namespace Database.Data.Entities
{
using Microsoft.AspNetCore.Identity;

    public class Usuarios : IdentityUser
    {
        public Personas Persona{ get; set; }

    }
}