using System;
using System.Collections.Generic;

namespace DatabaseConnection.Models.Entity;

public class Dashboard
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<NoteEntity> SingleNotes { get; set; }
    public List<DayPlanner> DayPlanners { get; set; }
    public Calender Calender { get; set; }
    public List<StickEntity> Sticks { get; set; }
    public List<CheckList> CheckLists { get; set; }
    public DateTime CreationDate { get; set; }
}