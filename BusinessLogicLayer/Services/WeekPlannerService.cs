using BusinessLogicLayer.Interfaceses;
using BusinessLogicLayer.Models;

namespace BusinessLogicLayer.Services;

public abstract class WeekPlannerService : IBaseService<WeekPlanner>
{
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