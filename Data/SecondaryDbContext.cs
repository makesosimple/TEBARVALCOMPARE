using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TEBARVALCOMPARE.Models;
using TEBARVALCOMPARE.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace TEBARVALCOMPARE.Data
{
    public class SecondaryDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public SecondaryDbContext(DbContextOptions<SecondaryDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }
    }
}
