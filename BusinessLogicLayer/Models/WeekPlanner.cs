namespace BusinessLogicLayer.Models;

public class WeekPlanner : BaseModel
{
    public List<DayPlanner> DayPlanners { get; set; }
}