using AutoMapper;
using BusinessLogicLayer.Exceptions;
using BusinessLogicLayer.Interfaces;
using DataAccessLayer;
using DataAccessLayer.Models.BusinessModels;
using DataAccessLayer.Models.EntityModel;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogicLayer.Services;

public abstract class NoteService : IBaseService<Note>
{
    private readonly DatabaseContext _context;
    private readonly IMapper _mapper;

    protected NoteService(DatabaseContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<Note>> GetAll()
    {
        var notes = _context.NoteEntities
            .ToList();

        return _mapper.Map<List<Note>>(notes);
    }

    public async Task<Note> GetById(Guid id)
    {
        var note = _context.NoteEntities
            .FirstOrDefault(x => x.Id == id);

        return _mapper.Map<Note>(note);
    }

    public async Task<string> Add(Note model)
    {
        var note = _mapper.Map<NoteEntity>(model);
        _context.NoteEntities.Add(note);
        _context.SaveChanges();

        return note.Id.ToString();
    }

    public void Delete(Guid id)
    {
        var note = _context.NoteEntities
            .FirstOrDefault(x => x.Id == id);

        if (note is null)
            throw new NotFoundException($"Note with this id: {id} not found ");

        _context.NoteEntities.Remove(note);
        _context.SaveChanges();
    }
}