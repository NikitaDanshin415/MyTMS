using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TMS.Domain;

namespace TMS.Application.Interfaces
{
    public interface ITmsDbContext
    {
        public DbSet<Domain.Project> Projects { get; set; }
        public DbSet<ProjectStatus> ProjectStatus { get; set; }
        public DbSet<TestCase> TestCases { get; set; }
        public DbSet<Domain.TestPlan> TestPlans { get; set; }
        public DbSet<TestPlanStatus> TestPlanStatus { get; set; }
        public DbSet<TestPlanCases> TestPlanCases { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ProjectParticipants> ProjectParticipants { get; set; }
        public DbSet<Domain.ProjectRole> ProjectRoles { get; set; }
        public DbSet<TestCaseStep> TestCaseSteps { get; set; }
        public DbSet<TestCaseResult> TestCaseResults { get; set; }
        public DbSet<TestStepResult> TestStepResults { get; set; }
        public DbSet<TestCaseResultResult> TestCaseResultResults { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
