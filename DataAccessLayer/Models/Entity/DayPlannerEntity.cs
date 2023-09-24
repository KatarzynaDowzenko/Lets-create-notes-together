namespace DataAccessLayer.Models.Entity;

public class DayPlannerEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string NoteTitle { get; set; }
    public string Note { get; set; }
    public DateTime CreationNoteDate { get; set; }
    public Guid DashboardId { get; set; }
    public DashboardEntity Dashboard { get; set; }
    public Guid WeekPlannerId { get; set; }
    public WeekPlannerEntity WeekPlanner { get; set; }
}