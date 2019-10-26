using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MoustacheApp.Models;

namespace MoustacheApp.Data
{
    public static class SeedIdentityData
    {
        public static async Task CreateRoles(IServiceProvider serviceProvider, IConfiguration Configuration)
        {
            // adding custom roles
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<AppRole>>();

            string[] roleName = { "L0", "L1", "L2", "L3", "L4", "L5" };
            string[] roleDesc = { "Anonymous user", "Quiz player", "Quiz staff", "Quiz manager",
                                    "Change levels", "App maintenance" };
            IdentityResult roleResult;

            for (int rn = 0; rn < roleName.Length; rn++)
            {
                // creating the roles and seeding them to the database
                var roleExist = await RoleManager.RoleExistsAsync(roleName[rn]);
                if (!roleExist)
                {
                    roleResult = await RoleManager.CreateAsync(new AppRole(roleName[rn], roleDesc[rn]));
                }
            }

            // adding custom users
            var UserManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();

            int numUsers = Int32.Parse(Configuration.GetSection("SeedUserConfig")["NumUsers"]);

            for (int su = 0; su < numUsers; su++)
            {
                var user = await UserManager.FindByNameAsync(Configuration.GetSection("SeedUserConfig")[$"UserName{su}"]);
                if (user == null)
                {
                    var customUser = new AppUser
                    {
                        UserName = Configuration.GetSection("SeedUserConfig")[$"UserName{su}"],
                    };
                    string userPassword = Configuration.GetSection("SeedUserConfig")[$"UserPassword{su}"];
                    string userRole = Configuration.GetSection("SeedUserConfig")[$"UserRole{su}"];

                    var createUser = await UserManager.CreateAsync(customUser, userPassword);
                    if (createUser.Succeeded)
                    {
                        await UserManager.AddToRoleAsync(customUser, userRole);
                    }
                }
            }
        }
    }
}