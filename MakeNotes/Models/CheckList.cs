using System;

namespace DatabaseConnection.Models.Entity;

public class CheckList
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string NoteTitle { get; set; }
    public string Note { get; set; }
    public bool IsDone { get; set; }
    public DateTime CreationNoteDate { get; set; }
}