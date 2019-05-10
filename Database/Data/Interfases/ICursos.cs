using Database.ModelsData;

namespace Database.Models
{
    public interface ICursos
    {
        int Id { get; set; }
        Materias Materia { get; set; }
        Profesores Profesor { get; set; }
    }
}