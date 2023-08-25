using System;
using System.Collections.Generic;

namespace DatabaseConnection.Models.Entity;

public class DashboardEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<NoteEntity> SingleNotes { get; set; }
    public List<DayPlannerEntity> DayPlanners { get; set; }
    public CalenderEntity Calender { get; set; }
    public List<StickEntity> Sticks { get; set; }
    public List<CheckListEntity> CheckLists { get; set; }
    public DateTime CreationDate { get; set; }
}