using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database.Data.Entities
{
    public class Calificaciones
    {
        public int id { get; set; }
        public DateTime FechaCalificacion { get; set; }
        public Alumnos Alumno { get; set; }

        public float Calificacion { get; set; }
    }
}
