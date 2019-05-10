namespace Database.Models
{

    using Database.ModelsData;

    public class Cursos : ICursos
    {
        public int Id { get; set; }
        public Materias Materia { get; set; }
        public Profesores Profesor { get; set; }


    }
}