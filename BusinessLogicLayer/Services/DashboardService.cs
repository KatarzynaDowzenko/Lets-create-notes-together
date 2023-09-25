using AutoMapper;
using BusinessLogicLayer.Exceptions;
using BusinessLogicLayer.Interfaces;
using DataAccessLayer;
using DataAccessLayer.Models.BusinessModels;
using DataAccessLayer.Models.EntityModel;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogicLayer.Services;

public abstract class DashboardService : IBaseService<Dashboard>
{
    private readonly DatabaseContext _context;
    private readonly IMapper _mapper;

    protected DashboardService(DatabaseContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<Dashboard>> GetAll()
    {
        var dashboards = _context.DashboardEntities
            .Include(x => x.CheckLists)
            .Include(x => x.DayPlanners)
            .Include(x => x.Notes)
            .Include(x => x.WeekPlanners)
            .ToList();

        return _mapper.Map<List<Dashboard>>(dashboards);
    }

    public async Task<Dashboard> GetById(Guid id)
    {
        var dashboard = _context.DashboardEntities
            .Include(x => x.CheckLists)
            .Include(x => x.DayPlanners)
            .Include(x => x.Notes)
            .Include(x => x.WeekPlanners)
            .FirstOrDefault(x => x.Id == id);

        return _mapper.Map<Dashboard>(dashboard);
    }

    public async Task<string> Add(Dashboard model)
    {
        var dashboard = _mapper.Map<DashboardEntity>(model);
        _context.DashboardEntities.Add(dashboard);
        _context.SaveChangesAsync();

        return dashboard.Id.ToString();
    }

    public void Delete(Guid id)
    {
        var dashboard = _context.DashboardEntities
            .Include(x => x.CheckLists)
            .Include(x => x.DayPlanners)
            .Include(x => x.Notes)
            .Include(x => x.WeekPlanners)
            .FirstOrDefault(x => x.Id == id);

        if (dashboard is null)
            throw new NotFoundException($"Dashboard with this id: {id} not found ");

        _context.DashboardEntities.Remove(dashboard);
        _context.SaveChanges();
    }
}