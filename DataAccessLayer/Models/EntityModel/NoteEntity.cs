using DataAccessLayer.Models.EntityModel.Enums;

namespace DataAccessLayer.Models.EntityModel;

public class NoteEntity
{
    public Guid Id { get; set; }
    public NoteTypeEntity NoteType { get; set; }
    public string Name { get; set; }
    public string NoteTitle { get; set; }
    public string Note { get; set; }
    public DateTime CreationNoteDate { get; set; }
    public Guid DashboardId { get; set; }
    public DashboardEntity Dashboard { get; set; }
}