using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using TitanInformationSolutions.Data;


namespace TitanInformationSolutions.Data
{
    public static class ApplicationSeedData
    {
        public static async Task SeedAsync(ApplicationDbContext context, IServiceProvider serviceProvider)
        {
            //Create Roles
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            string[] roleNames = { "Instructor" };
            IdentityResult roleResult;
            foreach (var roleName in roleNames)
            {
                var roleExist = await RoleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    roleResult = await RoleManager.CreateAsync(new IdentityRole(roleName));
                }
            }
            //Create Users
            var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
            if (userManager.FindByEmailAsync("jcricket@gmail.com").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "jcricket@gmail.com",
                    Email = "jcricket@gmail.com"
                };

                IdentityResult result = userManager.CreateAsync(user, "password").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Instructor").Wait();
                }
            }
            if (userManager.FindByEmailAsync("caroleh@yahoo.com").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "caroleh@yahoo.com",
                    Email = "caroleh@yahoo.com"
                };

                IdentityResult result = userManager.CreateAsync(user, "password").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Instructor").Wait();
                }
            }
            if (userManager.FindByEmailAsync("fripp@hotmail.com").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "fripp@hotmail.com",
                    Email = "fripp@hotmail.com"
                };

                IdentityResult result = userManager.CreateAsync(user, "password").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Instructor").Wait();
                }
            }
            if (userManager.FindByEmailAsync("user1@outlook.com").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "user1@outlook.com",
                    Email = "user1@outlook.com"
                };

                IdentityResult result = userManager.CreateAsync(user, "password").Result;                
            }
        }
    }
}
