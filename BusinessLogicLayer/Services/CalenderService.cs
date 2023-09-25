using AutoMapper;
using BusinessLogicLayer.Exceptions;
using BusinessLogicLayer.Interfaces;
using DataAccessLayer;
using DataAccessLayer.Models.BusinessModels;
using DataAccessLayer.Models.EntityModel;

namespace BusinessLogicLayer.Services;

public abstract class CalenderService : IBaseService<Calender>
{
    private readonly DatabaseContext _context;
    private readonly IMapper _mapper;

    protected CalenderService(DatabaseContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<Calender>> GetAll()
    {
        var calenders = _context.CalenderEntities
            .ToString();

        return _mapper.Map<List<Calender>>(calenders);
    }

    public async Task<Calender> GetById(Guid id)
    {
        var calender = _context.CalenderEntities
            .FirstOrDefault(x => x.Id == id);

        return _mapper.Map<Calender>(calender);
    }

    public async Task<string> Add(Calender model)
    {
        var calender = _mapper.Map<CalenderEntity>(model);
        _context.CalenderEntities.Add(calender);
        _context.SaveChangesAsync();

        return calender.Id.ToString();
    }

    public void Delete(Guid id)
    {
        var calender = _context.CalenderEntities
            .FirstOrDefault(x => x.Id == id);

        if (calender is null)
            throw new NotFoundException($"Calender with this id: {id} not found ");

        _context.CalenderEntities.Remove(calender);
        _context.SaveChanges();
    }
}