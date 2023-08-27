namespace BusinessLogicLayer.Models;

public abstract class BaseModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime CreationDate { get; set; }
}

public abstract class BaseNoteModel : BaseModel
{
    public string NoteTitle { get; set; }
    public string Note { get; set; }
}