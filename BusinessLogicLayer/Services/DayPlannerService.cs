using BusinessLogicLayer.Interfaceses;
using BusinessLogicLayer.Models;

namespace BusinessLogicLayer.Services;

public abstract class DayPlannerService : IBaseService<DayPlanner>
{
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