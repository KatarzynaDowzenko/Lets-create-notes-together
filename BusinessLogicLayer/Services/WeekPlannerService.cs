using AutoMapper;
using BusinessLogicLayer.Exceptions;
using BusinessLogicLayer.Interfaces;
using DataAccessLayer;
using DataAccessLayer.Models.BusinessModels;
using DataAccessLayer.Models.EntityModel;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogicLayer.Services;

public abstract class WeekPlannerService : IBaseService<WeekPlanner>
{
    private readonly DatabaseContext _context;
    private readonly IMapper _mapper;

    protected WeekPlannerService(DatabaseContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<WeekPlanner>> GetAll()
    {
        var weekPlanners = _context.WeekPlannerEntities
            .Include(x => x.DayPlanners)
            .ToList();

        return _mapper.Map<List<WeekPlanner>>(weekPlanners);
    }

    public async Task<WeekPlanner> GetById(Guid id)
    {
        var weekPlanner = _context.WeekPlannerEntities
            .Include(x => x.DayPlanners)
            .FirstOrDefault(x => x.Id == id);

        return _mapper.Map<WeekPlanner>(weekPlanner);
    }

    public async Task<string> Add(WeekPlanner model)
    {
        var weekPlanner = _mapper.Map<WeekPlannerEntity>(model);
        _context.WeekPlannerEntities.Add(weekPlanner);
        _context.SaveChangesAsync();

        return weekPlanner.Id.ToString();
    }

    public void Delete(Guid id)
    {
        var weekPlanner = _context.WeekPlannerEntities
            .Include(x => x.DayPlanners)
            .FirstOrDefault(x => x.Id == id);

        if (weekPlanner is null)
            throw new NotFoundException($"Week planner with this id: {id} not found ");

        _context.WeekPlannerEntities.Remove(weekPlanner);
        _context.SaveChanges();
    }
}