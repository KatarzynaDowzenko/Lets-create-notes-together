namespace DataAccessLayer.Models.Entity;

public class DashboardEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<NoteEntity> Notes { get; set; }
    public List<DayPlannerEntity> DayPlanners { get; set; }
    public CalenderEntity Calender { get; set; }
    public List<WeekPlannerEntity> WeekPlanners { get; set; }
    public List<CheckListEntity> CheckLists { get; set; }
    public DateTime CreationDate { get; set; }
}