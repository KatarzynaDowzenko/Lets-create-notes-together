using AutoMapper;
using BusinessLogicLayer.Interfaceses;
using BusinessLogicLayer.Models;
using DataAccessLayer;

namespace BusinessLogicLayer.Services;

public abstract class CheckListService : IBaseService<CheckList>
{
    private readonly DatabaseContext _context;
    private readonly IMapper _mapper;
    private readonly ILogger<CalenderService> _logger;

    public CheckListService(DatabaseContext context, IMapper mapper, ILogger<CalenderService> logger)
    {
        _context = context;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<List<CheckList>> GetAll()
    {
        throw new NotImplementedException();
    }

    public async Task<CheckList> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<string> Add(CheckList model)
    {
        throw new NotImplementedException();
    }

    public async Task<CheckList> Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}