using BusinessLogicLayer.Models.Enums;

namespace BusinessLogicLayer.Models;

public class Note : BaseNoteModel
{
    public bool IsImportant { get; set; }
    public NoteType NoteType { get; set; }
}