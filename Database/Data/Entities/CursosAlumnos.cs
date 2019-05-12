namespace Database.Models
{
    public class CursosAlumnos
    {
        public int Id { get; set; }
        public Alumnos AlumnoId { get; set; }
        public Cursos CursoId { get; set; }
    }
}
