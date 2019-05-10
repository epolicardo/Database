namespace Database.Data
{
    using Models;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class RepositorioAlumnos
    {
        private readonly DataContext context;

        public RepositorioAlumnos(DataContext context)
        {
            this.context = context;
        }

        //Retorna una lista de alumnos
        public IEnumerable<Alumnos> GetAlumnos()
        {
            return this.context.Alumnos.OrderBy(m => m.Persona.Apellido);
        }

        //Retorna solo un alumno segun su ID
        public Alumnos GetAlumno(int id)
        {
            return this.context.Alumnos.Find(id);
        }

        //Añade un Alumno Nuevo
        public void AddAlumno(Alumnos alumnos)
        {
            this.context.Alumnos.Add(alumnos);
        }

        public void UpdateAlumno(Alumnos alumnos)
        {
            this.context.Update(alumnos);
        }
        public void RemoveAlumno(Alumnos alumnos)
        {
            this.context.Alumnos.Remove(alumnos);
        }

        public async Task<bool> SaveAllAsync()
        {
            return await this.context.SaveChangesAsync() > 0;
        }

        public bool ExisteAlumno(string id)
        {
            return this.context.Alumnos.Any(m => m.Id == id);
        }
    }
}
