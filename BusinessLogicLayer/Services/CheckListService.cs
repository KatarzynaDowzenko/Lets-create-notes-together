using BusinessLogicLayer.Interfaceses;
using BusinessLogicLayer.Models;

namespace BusinessLogicLayer.Services;

public abstract class CheckListService : IBaseService<CheckList>
{
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