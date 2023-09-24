namespace DataAccessLayer.Models.EntityModel;

public class CheckListEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string NoteTitle { get; set; }
    public string Note { get; set; }
    public bool IsDone { get; set; }
    public DateTime CreationNoteDate { get; set; }
    public Guid DashboardId { get; set; }
    public DashboardEntity Dashboard { get; set; }
}