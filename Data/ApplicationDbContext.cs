using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using IBBPortal.Models;
using Microsoft.AspNetCore.Identity;

namespace IBBPortal.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityUserClaim<string>>(b =>
            {
                b.ToTable("ApplicationUserClaim");
            });

            modelBuilder.Entity<IdentityUserLogin<string>>(b =>
            {
                b.ToTable("ApplicationUserLogin");
            });

            modelBuilder.Entity<IdentityUserToken<string>>(b =>
            {
                b.ToTable("ApplicationUserToken");
            });

            modelBuilder.Entity<IdentityRole>(b =>
            {
                b.ToTable("ApplicationRole");
            });

            modelBuilder.Entity<IdentityRoleClaim<string>>(b =>
            {
                b.ToTable("ApplicationRoleClaim");
            });

            modelBuilder.Entity<IdentityUserRole<string>>(b =>
            {
                b.ToTable("ApplicationUserRole");
            });
        }

        public DbSet<IBBPortal.Models.ApplicationUser> ApplicationUser { get; set; }

        public DbSet<IBBPortal.Models.ApplicationRole> ApplicationRole { get; set; }

        public DbSet<IBBPortal.Models.Board> Board { get; set; }

        public DbSet<IBBPortal.Models.City> City { get; set; }

        public DbSet<IBBPortal.Models.Contractor> Contractor { get; set; }

        public DbSet<IBBPortal.Models.District> District { get; set; }

        public DbSet<IBBPortal.Models.JobTitle> JobTitle { get; set; }

        public DbSet<IBBPortal.Models.Department> Department { get; set; }

        public DbSet<IBBPortal.Models.Phase> Phase { get; set; }

        public DbSet<IBBPortal.Models.Authority> Authority { get; set; }

        public DbSet<IBBPortal.Models.ZoningPlanStatus> ZoningPlanStatus { get; set; }

        public DbSet<IBBPortal.Models.ProjectTeamCategory> ProjectTeamCategory { get; set; }

        public DbSet<IBBPortal.Models.ProjectStatus> ProjectStatus { get; set; }

        public DbSet<IBBPortal.Models.ProjectPhaseStatus> ProjectPhaseStatus { get; set; }

        public DbSet<IBBPortal.Models.FileCategory> FileCategory { get; set; }

        public DbSet<IBBPortal.Models.ServiceArea> ServiceArea { get; set; }

        public DbSet<IBBPortal.Models.Subfunction> Subfunction { get; set; }

        public DbSet<IBBPortal.Models.SubfunctionFeature> SubfunctionFeature { get; set; }

        public DbSet<IBBPortal.Models.ContractorType> ContractorType { get; set; }

        public DbSet<IBBPortal.Models.ZoningPlanModificationStatus> ZoningPlanModificationStatus { get; set; }

        public DbSet<IBBPortal.Models.ProjectImportance> ProjectImportance { get; set; }

        public DbSet<IBBPortal.Models.RelationType> RelationType { get; set; }

        public DbSet<IBBPortal.Models.Person> Person { get; set; }

        public DbSet<IBBPortal.Models.Project> Project { get; set; }

        public DbSet<IBBPortal.Models.ProjectBoardApproval> ProjectBoardApproval { get; set; }

        public DbSet<IBBPortal.Models.ProjectZoningPlan> ProjectZoningPlan { get; set; }

        public DbSet<IBBPortal.Models.ProjectExpropriation> ProjectExpropriation { get; set; }

        public DbSet<IBBPortal.Models.ProjectPermission> ProjectPermission { get; set; }

        public DbSet<IBBPortal.Models.JobField> JobField { get; set; }

        public DbSet<IBBPortal.Models.ProjectPerson> ProjectPerson { get; set; }

        public DbSet<IBBPortal.Models.ProjectRelation> ProjectRelation { get; set; }

        public DbSet<IBBPortal.Models.PropertyStatus> PropertyStatus { get; set; }

        public DbSet<IBBPortal.Models.Organization> Organization { get; set; }
    }


}
