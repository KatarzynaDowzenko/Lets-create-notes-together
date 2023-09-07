using AutoMapper;
using BusinessLogicLayer.Interfaceses;
using BusinessLogicLayer.Models;
using DataAccessLayer;

namespace BusinessLogicLayer.Services;

public abstract class WeekPlannerService : IBaseService<WeekPlanner>
{
    private readonly DatabaseContext _context;
    private readonly IMapper _mapper;
    private readonly ILogger<WeekPlannerService> _logger;

    protected WeekPlannerService(DatabaseContext context, IMapper mapper, ILogger<WeekPlannerService> logger)
    {
        _context = context;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<List<WeekPlanner>> GetAll()
    {
        throw new NotImplementedException();
    }

    public async Task<WeekPlanner> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<string> Add(WeekPlanner model)
    {
        throw new NotImplementedException();
    }

    public async Task<WeekPlanner> Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}