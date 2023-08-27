namespace BusinessLogicLayer.Models;

public class Dashboard
{
    public List<Note> SingleNotes { get; set; }
    public List<DayPlanner> DayPlanners { get; set; }
    public Calender Calender { get; set; }
    public List<Note> Notes { get; set; }
    public List<CheckList> CheckLists { get; set; }
}