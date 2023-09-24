using AutoMapper;
using BusinessLogicLayer.Interfaces;
using DataAccessLayer;
using DataAccessLayer.Models.BusinessModels;

namespace BusinessLogicLayer.Services;

public abstract class DashboardService : IBaseService<Dashboard>
{
    private readonly DatabaseContext _context;
    private readonly IMapper _mapper;
    private readonly ILogger<DashboardService> _logger;

    protected DashboardService(DatabaseContext context, IMapper mapper, ILogger<DashboardService> logger)
    {
        _context = context;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<List<Dashboard>> GetAll()
    {
        throw new NotImplementedException();
    }

    public async Task<Dashboard> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<string> Add(Dashboard model)
    {
        throw new NotImplementedException();
    }

    public async Task<Dashboard> Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}