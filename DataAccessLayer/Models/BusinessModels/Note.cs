using DataAccessLayer.Models.BusinessModels.Enums;

namespace DataAccessLayer.Models.BusinessModels;

public class Note : BaseNoteModel
{
    public bool IsImportant { get; set; }
    public NoteType NoteType { get; set; }
}