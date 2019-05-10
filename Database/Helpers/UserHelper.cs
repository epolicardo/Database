namespace Database.Helpers
{
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Models;

    public class UserHelper
    {
        private readonly UserManager<Usuarios> userManager;


        public UserHelper(UserManager<Usuarios> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<IdentityResult> AddUsuarioAsync(Usuarios usuario, string password)
        {
            return await this.userManager.CreateAsync(usuario, password);
        }

        public async Task<Usuarios> GetUsuariosByCorreoAsync(string correo)
        {
            return await this.userManager.FindByEmailAsync(correo);
        }


    }
}
