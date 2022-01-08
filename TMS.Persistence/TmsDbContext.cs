using System;
using System.Threading;
using System.Threading.Tasks;
using TMS.Domain;
using Microsoft.EntityFrameworkCore;
using TMS.Application.Interfaces;

namespace TMS.Persistence
{
    public class TmsDbContext : DbContext, ITmsDbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectStatus> ProjectStatus { get; set; }
        public DbSet<TestCase> TestCases { get; set; }
        public DbSet<TestPlan> TestPlans { get; set; }
        public DbSet<TestPlanStatus> TestPlanStatus { get; set; }
        public DbSet<TestPlanCases> TestPlanCases { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ProjectParticipants> ProjectParticipants { get; set; }
        public DbSet<ProjectRole> ProjectRoles { get; set; }
        public DbSet<TestCaseStep> TestCaseSteps { get; set; }
        public DbSet<TestCaseResult> TestCaseResults { get; set; }
        public DbSet<TestStepResult> TestStepResults { get; set; }
        public DbSet<TestCaseResultResult> TestCaseResultResults { get; set; }
        

        public TmsDbContext(DbContextOptions<TmsDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}