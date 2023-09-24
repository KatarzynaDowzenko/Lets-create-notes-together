using AutoMapper;
using BusinessLogicLayer.Interfaces;
using DataAccessLayer;
using DataAccessLayer.Models.BusinessModels;

namespace BusinessLogicLayer.Services;

public abstract class NoteService : IBaseService<Note>
{
    private readonly DatabaseContext _context;
    private readonly IMapper _mapper;
    private readonly ILogger<NoteService> _logger;

    protected NoteService(DatabaseContext context, IMapper mapper, ILogger<NoteService> logger)
    {
        _context = context;
        _mapper = mapper;
        _logger = logger;
    }

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