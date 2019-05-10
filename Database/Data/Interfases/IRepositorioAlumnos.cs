using System.Collections.Generic;
using System.Threading.Tasks;
using Database.Models;

namespace Database.Data
{
    public interface IRepositorioAlumnos
    {
        void AddAlumno(Alumnos alumnos);
        bool ExisteAlumno(string id);
        Alumnos GetAlumno(int id);
        IEnumerable<Alumnos> GetAlumnos();
        void RemoveAlumno(Alumnos alumnos);
        Task<bool> SaveAllAsync();
        void UpdateAlumno(Alumnos alumnos);
    }
}