using DataAccessLayer.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }

    public virtual DbSet<CalenderEntity> CalenderEntities { get; set; }
    public virtual DbSet<CheckListEntity> CheckListEntities { get; set; }
    public virtual DbSet<DashboardEntity> DashboardEntities { get; set; }
    public virtual DbSet<DayPlannerEntity> DayPlannerEntities { get; set; }
    public virtual DbSet<NoteEntity> NoteEntities { get; set; }
    public virtual DbSet<WeekPlannerEntity> WeekPlannerEntities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DashboardEntity>()
            .HasMany<CheckListEntity>(d => d.CheckLists)
            .WithOne(cl => cl.Dashboard)
            .HasForeignKey(cl => cl.DashboardId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<DashboardEntity>()
            .HasMany<DayPlannerEntity>(d => d.DayPlanners)
            .WithOne(dp => dp.Dashboard)
            .HasForeignKey(dp => dp.DashboardId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<DashboardEntity>()
            .HasMany(d => d.Notes)
            .WithOne(n => n.Dashboard)
            .HasForeignKey(n => n.DashboardId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<DashboardEntity>()
            .HasMany(d => d.WeekPlanners)
            .WithOne(wp => wp.Dashboard)
            .HasForeignKey(n => n.DashboardId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<WeekPlannerEntity>()
            .HasMany(wp => wp.DayPlanners)
            .WithOne(dp => dp.WeekPlanner)
            .HasForeignKey(dp => dp.WeekPlannerId)
            .OnDelete(DeleteBehavior.Cascade);

        base.OnModelCreating(modelBuilder);
    }
}