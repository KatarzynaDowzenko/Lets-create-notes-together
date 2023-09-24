namespace DataAccessLayer.Models.BusinessModels;

public class WeekPlanner : BaseModel
{
    public List<DayPlanner> DayPlanners { get; set; }
}