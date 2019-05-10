namespace Database.Data
{
    using Models;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class RepositorioCursos : IRepositorioMensajes
    {
        private readonly DataContext context;

        public RepositorioCursos(DataContext context)
        {
            this.context = context;
        }

        public IEnumerable<Mensajes> GetMensajes()
        {
            return this.context.Mensajes.OrderBy(m => m.FechaEnviado);
        }

        public Mensajes GetMensaje(int id)
        {
            return this.context.Mensajes.Find(id);
        }

        public void AddMensaje(Mensajes mensaje)
        {
            this.context.Mensajes.Add(mensaje);
        }

        public void UpdateMensaje(Mensajes mensaje)
        {
            this.context.Update(mensaje);
        }
        public void RemoveMensaje(Mensajes mensaje)
        {
            this.context.Mensajes.Remove(mensaje);
        }

        public async Task<bool> SaveAllAsync()
        {
            return await this.context.SaveChangesAsync() > 0;
        }

        public bool MensajeExiste(int id)
        {
            return this.context.Mensajes.Any(m => m.Id == id);
        }
    }
}
