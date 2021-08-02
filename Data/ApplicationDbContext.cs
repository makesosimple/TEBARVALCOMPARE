using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using IBBPortal.Models;

namespace IBBPortal.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<IBBPortal.Models.Board> Board { get; set; }

        public DbSet<IBBPortal.Models.City> City { get; set; }

        public DbSet<IBBPortal.Models.Contractor> Contractor { get; set; }

        public DbSet<IBBPortal.Models.District> District { get; set; }

        public DbSet<IBBPortal.Models.JobTitle> JobTitle { get; set; }

        public DbSet<IBBPortal.Models.Department> Department { get; set; }

        public DbSet<IBBPortal.Models.Phase> Phase { get; set; }

        public DbSet<IBBPortal.Models.Management> Management { get; set; }

        public DbSet<IBBPortal.Models.ZoningPlanStatus> ZoningPlanStatus { get; set; }

        public DbSet<IBBPortal.Models.ProjectTeamCategory> ProjectTeamCategory { get; set; }

        public DbSet<IBBPortal.Models.FileCategory> FileCategory { get; set; }

        public DbSet<IBBPortal.Models.ServiceArea> ServiceArea { get; set; }

    }


}
