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

        public DbSet<IBBPortal.Models.Bidding> Bidding { get; set; }

        public DbSet<IBBPortal.Models.Board> Board { get; set; }

        public DbSet<IBBPortal.Models.City> City { get; set; }

        public DbSet<IBBPortal.Models.Contractor> Contractor { get; set; }

        public DbSet<IBBPortal.Models.Department> Department { get; set; }

        public DbSet<IBBPortal.Models.District> District { get; set; }

        public DbSet<IBBPortal.Models.File> File { get; set; }

        public DbSet<IBBPortal.Models.FileCategories> JobTitle { get; set; }

        public DbSet<IBBPortal.Models.Management> Management { get; set; }

        public DbSet<IBBPortal.Models.Phase> Person { get; set; }

        public DbSet<IBBPortal.Models.Project> Project { get; set; }

        public DbSet<IBBPortal.Models.ProjectBoardApproval> ProjectBoardApproval { get; set; }

        public DbSet<IBBPortal.Models.ProjectContractor> ProjectContractor { get; set; }

        public DbSet<IBBPortal.Models.ProjectExpropriation> ProjectExpropriation { get; set; }

        public DbSet<IBBPortal.Models.ProjectFeasibility> ProjectFeasibility { get; set; }

        public DbSet<IBBPortal.Models.ProjectImportance> ProjectImportance { get; set; }

        public DbSet<IBBPortal.Models.ProjectPermission> ProjectPermission { get; set; }

        public DbSet<IBBPortal.Models.ProjectPhase> ProjectPhase { get; set; }

        public DbSet<IBBPortal.Models.ProjectStatus> ProjectStatus { get; set; }

        public DbSet<IBBPortal.Models.ProjectTeamCategory> ProjectTeamCategory { get; set; }

        public DbSet<IBBPortal.Models.ProjectZoningPlan> ProjectZoningPlan { get; set; }

        public DbSet<IBBPortal.Models.ServiceAreas> ServiceAreas { get; set; }

        public DbSet<IBBPortal.Models.Shortcuts> Shortcuts { get; set; }

        public DbSet<IBBPortal.Models.ZoningPlanModificationStatus> ZoningPlanModificationStatus { get; set; }

        public DbSet<IBBPortal.Models.ZoningPlanStatus> ZoningPlanStatus { get; set; }
    }


}
