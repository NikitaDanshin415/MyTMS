﻿using System;
using System.Threading;
using System.Threading.Tasks;
using TMS.Domain;
using Microsoft.EntityFrameworkCore;
using TMS.Application.Interfaces;
using TMS.Persistence.EntityTypeConfiguration;

namespace TMS.Persistence
{
    public class TmsDbContext : DbContext, ITmsDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectStatus> ProjectStatus { get; set; }
        public DbSet<ProjectRole> ProjectRoles { get; set; }
        public DbSet<ProjectParticipants> ProjectParticipants { get; set; }

        public TmsDbContext(DbContextOptions<TmsDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectStatusConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectRoleConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectParticipantsConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}