using BusinessLogicLayer.Interfaceses;
using BusinessLogicLayer.Models;

namespace BusinessLogicLayer.Services;

public abstract class CalenderService : IBaseService<Calender>
{
    public Task<List<Calender>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<Calender> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<string> Add(Calender model)
    {
        throw new NotImplementedException();
    }

    public Task<Calender> Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}