namespace BusinessLogicLayer.Interfaces;

public interface IBaseService<TBaseModel>
{
    Task<List<TBaseModel>> GetAll();
    Task<TBaseModel> GetById(Guid id);
    Task<string> Add(TBaseModel model);
    void Delete(Guid id);
}