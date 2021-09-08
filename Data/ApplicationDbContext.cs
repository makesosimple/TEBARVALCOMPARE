using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using IBBPortal.Models;
using IBBPortal.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace IBBPortal.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable(name: "User");
            });
            builder.Entity<ApplicationRole>(entity =>
            {
                entity.ToTable(name: "Role");
            });
            builder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("UserRoles");
            });
            builder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("UserClaims");
            });
            builder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("UserLogins");
            });
            builder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("RoleClaims");
            });
            builder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("UserTokens");
            });

            builder.Entity<DashboardSummaryModel>().HasNoKey();
            builder.Entity<ShortcutListModel>().HasNoKey();
            builder.Entity<ServicePieChartModel>().HasNoKey();
            builder.Entity<DashboardLineGraphModel>().HasNoKey();
            //modelBuilder.Ignore<DashboardSummaryModel>();
            //modelBuilder.Ignore<ShortcutListModel>();

        }

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

        public DbSet<IBBPortal.Models.ProjectField> ProjectField { get; set; }

        public DbSet<IBBPortal.Models.ProjectBoardApproval> ProjectBoardApproval { get; set; }

        public DbSet<IBBPortal.Models.ProjectZoningPlan> ProjectZoningPlan { get; set; }

        public DbSet<IBBPortal.Models.ProjectExpropriation> ProjectExpropriation { get; set; }

        public DbSet<IBBPortal.Models.ProjectPermission> ProjectPermission { get; set; }

        public DbSet<IBBPortal.Models.JobField> JobField { get; set; }

        public DbSet<IBBPortal.Models.ProjectPerson> ProjectPerson { get; set; }

        public DbSet<IBBPortal.Models.ProjectRelation> ProjectRelation { get; set; }
        
        public DbSet<IBBPortal.Models.Shortcuts> Shortcuts { get; set; }
        
        public DbSet<IBBPortal.Models.PropertyStatus> PropertyStatus { get; set; }

        public DbSet<IBBPortal.Models.Organization> Organization { get; set; }
        
        public DbSet<IBBPortal.Models.TransactionTypes> TransactionTypes { get; set; }

        public DbSet<IBBPortal.Models.TransactionMessages> TransactionMessages { get; set; }

        

        public DbSet<IBBPortal.Models.ExpropriationStatus> ExpropriationStatus { get; set; }

        public DbSet<IBBPortal.Models.ProjectFeasibility> ProjectFeasibility { get; set; }

        public DbSet<IBBPortal.Models.ProjectSubfunctionFeature> ProjectSubfunctionFeature { get; set; }

        public DbSet<IBBPortal.Models.ProjectPhase> ProjectPhase { get; set; }

        public DbSet<IBBPortal.Models.ProjectBidding> ProjectBidding { get; set; }

        [NotMapped]
        public DbSet<IBBPortal.ViewModels.DashboardSummaryModel> DashboardSummaryModel { get; set; }

        [NotMapped]
        public DbSet<IBBPortal.ViewModels.ShortcutListModel> ShortcutListModel { get; set; }

        [NotMapped]
        public DbSet<IBBPortal.ViewModels.ServicePieChartModel> ServicePieChartModel { get; set; }

        [NotMapped]
        public DbSet<IBBPortal.ViewModels.DashboardLineGraphModel> DashboardLineGraphModel { get; set; }

        



    }


}
