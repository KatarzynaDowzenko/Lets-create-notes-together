using DatabaseConnection.Models.Entity;

namespace BusinessLogicLayer.Services;

public interface IDashboardService
{
    List<Dashboard> GetAll();
    Dashboard GetById(Guid id);
    object Add(Dashboard dashboard);
    Dashboard Delete(Guid id);
}

public class DashboardService : IDashboardService
{
    public List<Dashboard> GetAll()
    {
        throw new NotImplementedException();
    }

    public Dashboard GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public object Add(Dashboard dashboard)
    {
        throw new NotImplementedException();
    }

    public Dashboard Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}