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
}