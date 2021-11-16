using System.Threading;
using System.Threading.Tasks;
using EntityFrameworkTest.Models;
using Microsoft.EntityFrameworkCore;

namespace TMS.Application.Interfaces
{
    public interface ITmsDbContext
    {
        public DbSet<ProjectStatus> ProjectStatus { get; set; }
        public DbSet<ProjectRole> ProjectRole { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<UserProjectRole> UserProjectRoles { get; set; }
        public DbSet<TestCase> TestCases { get; set; }
        public DbSet<TestPlanStatus> TestPlanStatus { get; set; }
        public DbSet<TestPlan> TestPlans { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<TestCaseResult> TestCaseResults { get; set; }
        public DbSet<TestCaseStep> TestCaseSteps { get; set; }
        public DbSet<TestCaseStepResult> TestCaseStepResults { get; set; }
        public DbSet<PlanTestcaseResult> PlanTestCaseResult { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
