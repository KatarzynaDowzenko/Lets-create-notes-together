namespace DataAccessLayer.Models.BusinessModels;

public abstract class BaseModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public DateTime CreationDate { get; set; }
}

public abstract class BaseNoteModel : BaseModel
{
    public string NoteTitle { get; set; }
    public string Note { get; set; }
}