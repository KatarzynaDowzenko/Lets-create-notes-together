using System;

namespace DataAccessLayer.Models.Entity;

public class StickEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string NoteTitle { get; set; }
    public string Note { get; set; }
    public bool IsImportant { get; set; }
    public DateTime CreationNoteDate { get; set; }
}