using AutoMapper;
using BusinessLogicLayer.Interfaces;
using DataAccessLayer;
using DataAccessLayer.Models.BusinessModels;

namespace BusinessLogicLayer.Services;

public abstract class DayPlannerService : IBaseService<DayPlanner>
{
    private readonly DatabaseContext _context;
    private readonly IMapper _mapper;
    private readonly ILogger<DayPlannerService> _logger;

    protected DayPlannerService(DatabaseContext context, IMapper mapper, ILogger<DayPlannerService> logger)
    {
        _context = context;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<List<DayPlanner>> GetAll()
    {
        throw new NotImplementedException();
    }

    public async Task<DayPlanner> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<string> Add(DayPlanner model)
    {
        throw new NotImplementedException();
    }

    public async Task<DayPlanner> Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}