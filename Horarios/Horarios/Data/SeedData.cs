using Horarios.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Horarios.Data
{
    public class SeedData
    {
        public static void EnsurePopulated(HorariosBDContext dbContext, IServiceProvider serviceProvider)
        {
            if (!dbContext.Roles.Any())
            {
                EnsureAdminPopulatedAsync(dbContext, serviceProvider).Wait();
            }
        }

        public static async Task EnsureAdminPopulatedAsync(HorariosBDContext dbContext, IServiceProvider serviceProvider)
        {
            //adding custom roles
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var UserManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            string[] roles = { "Administrador", "Professor", "Estudante" };

            foreach (var nome in roles)
            {
                var roleExiste = await RoleManager.RoleExistsAsync(nome);
                if (!roleExiste)
                {
                    await RoleManager.CreateAsync(new IdentityRole(nome));
                }
            }

            var admin = new ApplicationUser() { UserName = "Admin", Email = "admin@admin.com", EmailConfirmed = true };

            var resultado = await UserManager.CreateAsync(admin, "123Qwe,.-");
            if (resultado.Succeeded)
            {
                await UserManager.AddToRoleAsync(admin, "Administrador");
            }
        }
    }
}
