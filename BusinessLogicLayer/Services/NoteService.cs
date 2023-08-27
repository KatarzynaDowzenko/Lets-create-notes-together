using BusinessLogicLayer.Interfaceses;
using BusinessLogicLayer.Models;

namespace BusinessLogicLayer.Services;

public abstract class NoteService : IBaseService<Note>
{
    public async Task<List<Note>> GetAll()
    {
        throw new NotImplementedException();
    }

    public async Task<Note> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<string> Add(Note model)
    {
        throw new NotImplementedException();
    }

    public async Task<Note> Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}