using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IBBPortal.Data;
using IBBPortal.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IBBPortal.Helpers
{
    /*
     * User and Role Seeder.
     * Will be used inside the Startup class.
     * Extendable for other table datas as well
     * @version 1.0.0
     * @warning: 
     *  - Make sure you have the root roles inserted before calling the seedUsers() method.
     *  - On try.. catch.. code block, remove throw; on production mode!
     */
    public class Seeder
    {
        private ApplicationDbContext _context;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public Seeder(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _context = context;
        }


        public async void SeedRoles()
        {
            try
            {
                if (!_context.Roles.Any(r => r.Name == "Admin"))
                {
                    await _roleManager.CreateAsync(new ApplicationRole
                    {
                        Name = "Admin",
                        RoleDescription = "En yetkili kullanıcı rolü. Uygulama ayarları ve ana proje alanlarını görüntüleme ve düzenleme yetkisine sahiptir.",
                        CreationDate = DateTime.Now
                    });
                }

                if (!_context.Roles.Any(r => r.Name == "Editör"))
                {
                    await _roleManager.CreateAsync(new ApplicationRole
                    {
                        Name = "Editör",
                        RoleDescription = "Projelerini görüntüleme ve kendi projelerini düzenleme yetkisine sahiptir. Uygulama ayarlarını göremez (İhaleler hariç!)",
                        CreationDate = DateTime.Now
                    });
                }

                if (!_context.Roles.Any(r => r.Name == "Ziyaretçi"))
                {
                    await _roleManager.CreateAsync(new ApplicationRole
                    {
                        Name = "Ziyaretçi",
                        RoleDescription = "Sadece projeleri görüntüleme yetkisine sahiptir. Düzenleme yapamaz.",
                        CreationDate = DateTime.Now
                    });
                }
            }

            catch
            {
                throw;
            }
        }

        public async void SeedUsers()
        {
            var user = new ApplicationUser
            {
                FirstName = "John",
                LastName = "Doe",
                UserName = "johndoe",
                Email = "mail@mail.com",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString()
            };

            if (!_context.Users.Any(u => u.UserName == user.UserName))
            {
                var password = new PasswordHasher<ApplicationUser>();
                var hashed = password.HashPassword(user, "Esc86tuo8*");
                user.PasswordHash = hashed;
                await _userManager.CreateAsync(user);
                await _userManager.AddToRoleAsync(user , "ADMIN");
            }

            await _context.SaveChangesAsync();
        }
    }
}