namespace DataAccessLayer.Models.EntityModel;

public class WeekPlannerEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public DateTime CreationDate { get; set; }
    public List<DayPlannerEntity> DayPlanners { get; set; }
    public Guid DashboardId { get; set; }
    public DashboardEntity Dashboard { get; set; }
}