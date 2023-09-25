using AutoMapper;
using BusinessLogicLayer.Exceptions;
using BusinessLogicLayer.Interfaces;
using DataAccessLayer;
using DataAccessLayer.Models.BusinessModels;
using DataAccessLayer.Models.EntityModel;

namespace BusinessLogicLayer.Services;

public abstract class CheckListService : IBaseService<CheckList>
{
    private readonly DatabaseContext _context;
    private readonly IMapper _mapper;

    protected CheckListService(DatabaseContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<CheckList>> GetAll()
    {
        var checkList = _context.CheckListEntities
            .ToList();

        return _mapper.Map<List<CheckList>>(checkList);
    }

    public async Task<CheckList> GetById(Guid id)
    {
        var checkList = _context.CheckListEntities
            .FirstOrDefault(x => x.Id == id);

        return _mapper.Map<CheckList>(checkList);
    }

    public async Task<string> Add(CheckList model)
    {
        var checkList = _mapper.Map<CheckListEntity>(model);
        _context.CheckListEntities.Add(checkList);
        _context.SaveChangesAsync();

        return checkList.Id.ToString();
    }

    public void Delete(Guid id)
    {
        var checkList = _context.CheckListEntities
            .FirstOrDefault(x => x.Id == id);

        if (checkList is null)
            throw new NotFoundException($"Check list with this id: {id} not found ");

        _context.CheckListEntities.Remove(checkList);
        _context.SaveChanges();
    }
}