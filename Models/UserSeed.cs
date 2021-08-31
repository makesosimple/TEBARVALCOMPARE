using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IBBPortal.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using IndexAttribute = Microsoft.EntityFrameworkCore.IndexAttribute;

namespace IBBPortal.Models
{
    public class UserSeed
    {
        private ApplicationDbContext _context;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public UserSeed(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _context = context;
        }

        public async void SeedAdminUser()
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

            if (!_context.Roles.Any(r => r.Name == "admin"))
            {
                await _roleManager.CreateAsync(new ApplicationRole { Name = "admin" });
            }

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