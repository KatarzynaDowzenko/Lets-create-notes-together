using AutoMapper;
using BusinessLogicLayer.Exceptions;
using BusinessLogicLayer.Interfaces;
using DataAccessLayer;
using DataAccessLayer.Models.BusinessModels;
using DataAccessLayer.Models.EntityModel;

namespace BusinessLogicLayer.Services;

public abstract class DayPlannerService : IBaseService<DayPlanner>
{
    private readonly DatabaseContext _context;
    private readonly IMapper _mapper;

    protected DayPlannerService(DatabaseContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<DayPlanner>> GetAll()
    {
        var dayPlanners = _context.DayPlannerEntities
            .ToList();

        return _mapper.Map<List<DayPlanner>>(dayPlanners);
    }

    public async Task<DayPlanner> GetById(Guid id)
    {
        var dayPlanner = _context.DayPlannerEntities
            .FirstOrDefault(x => x.Id == id);

        return _mapper.Map<DayPlanner>(dayPlanner);
    }

    public async Task<string> Add(DayPlanner model)
    {
        var dayPlanner = _mapper.Map<DayPlannerEntity>(model);
        _context.DayPlannerEntities.Add(dayPlanner);
        _context.SaveChangesAsync();

        return dayPlanner.Id.ToString();
    }

    public void Delete(Guid id)
    {
        var dayPlanner = _context.DayPlannerEntities
            .FirstOrDefault(x => x.Id == id);

        if (dayPlanner is null)
            throw new NotFoundException($"Day planner with this id: {id} not found ");

        _context.DayPlannerEntities.Remove(dayPlanner);
        _context.SaveChanges();
    }
}