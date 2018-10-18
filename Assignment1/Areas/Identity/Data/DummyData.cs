using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment1.Models;
using Microsoft.AspNetCore.Identity;

namespace Assignment1.Areas.Identity.Data
{
    public class DummyData
    {
        public static async Task Initialize(Assignment1Context context,
                              RoleManager<IdentityRole> roleManager, UserManager<Assignment1User> userManager)
        {
            context.Database.EnsureCreated();

            String adminId1 = "";
            String adminId2 = "";

            string role1 = "Admin";
            string desc1 = "This is the administrator role";

            string role2 = "Member";
            string desc2 = "This is the members role";

            if (await roleManager.FindByNameAsync(role1) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(role1));
            }
            if (await roleManager.FindByNameAsync(role2) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(role2));
            }

            if (await userManager.FindByEmailAsync("a@a.a") == null)
            {
                Assignment1User newUser = new Assignment1User();
                newUser.AddressCity = "vancouver";
                newUser.AddressCountry = "canada";
                newUser.AddressProvince = "bc";
                newUser.AddressStreet = "123";
                newUser.Email = "a@a.a";
                newUser.FirstName = "wow";
                newUser.LastName = "weow";
                newUser.UserName = "a";
                newUser.Role = "Admin";
                var result = await userManager.CreateAsync(newUser, "P@$$w0rd");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(newUser, "Admin");
                }
            }

            if (await userManager.FindByEmailAsync("m@m.m") == null)
            {
                Assignment1User newUser = new Assignment1User();
                newUser.AddressCity = "vancouver";
                newUser.AddressCountry = "canada";
                newUser.AddressProvince = "bc";
                newUser.AddressStreet = "123";
                newUser.Email = "m@m.m";
                newUser.FirstName = "wow";
                newUser.LastName = "weow";
                newUser.UserName = "m";
                newUser.Role = "Member";
                var result = await userManager.CreateAsync(newUser, "P@$$w0rd");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(newUser, "Member");
                }
            }

        }
    }
}
