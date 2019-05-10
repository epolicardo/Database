using System.Threading.Tasks;
using Database.Models;
using Microsoft.AspNetCore.Identity;

namespace Database.Helpers
{
    public interface IUserHelper
    {
        Task<IdentityResult> AddUsuarioAsync(Usuarios usuario, string password);
    }
}