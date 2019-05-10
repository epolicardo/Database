namespace Database.Data
{

using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

    public interface IRepositorioMensajes
    {
        void AddMensaje(Mensajes mensaje);
        Mensajes GetMensaje(int id);
        IEnumerable<Mensajes> GetMensajes();
        bool MensajeExiste(int id);
        void RemoveMensaje(Mensajes mensaje);
        Task<bool> SaveAllAsync();
        void UpdateMensaje(Mensajes mensaje);
    }
}