using AutoMapper;
using BusinessLogicLayer.Interfaceses;
using BusinessLogicLayer.Models;
using DataAccessLayer;

namespace BusinessLogicLayer.Services;

public abstract class CalenderService : IBaseService<Calender>
{
    private readonly DatabaseContext _context;
    private readonly IMapper _mapper;
    private readonly ILogger<CalenderService> _logger;

    protected CalenderService(DatabaseContext context, IMapper mapper, ILogger<CalenderService> logger)
    {
        _context = context;
        _mapper = mapper;
        _logger = logger;
    }

    public Task<List<Calender>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<Calender> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<string> Add(Calender model)
    {
        throw new NotImplementedException();
    }

    public Task<Calender> Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}