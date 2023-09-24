using BusinessLogicLayer.Exceptions;
using BusinessLogicLayer.Interfaceses;
using Microsoft.AspNetCore.Mvc;

namespace BusinessLogicLayer.Controllers;

[ApiController]
[Route("api/[controller]")]
public abstract class BaseController<TModel, TService> : ControllerBase where TService : IBaseService<TModel>
{
    private readonly ILogger<BaseController<TModel, TService>> _logger;
    private readonly TService _service;

    protected BaseController(TService service, ILogger<BaseController<TModel, TService>> logger)
    {
        _service = service;
        _logger = logger;
    }

    [HttpGet]
    public async Task<List<TModel>> GetAll()
    {
        try
        {
            var allModel = await _service.GetAll();
            return allModel;
        }
        catch (Exception e)
        {
            _logger.LogError(e,
                $"Error! {nameof(BaseController<TModel, TService>)}, Method: {nameof(GetAll)} Error: {e} \nInnerException: {e.InnerException}");

            throw new Exception("Sorry, we have a problem with the process of your request. Error information:", e);
        }
    }

    [HttpGet("{id}")]
    public async Task<TModel> Get([FromRoute] Guid id)
    {
        try
        {
            var model = await _service.GetById(id);
            return model;
        }
        catch (NotFoundException e)
        {
            _logger.LogError(e,
                $"Error! {nameof(BaseController<TModel, TService>)}, Method: {nameof(Get)} Error: {e} \nInnerException: {e.InnerException}");

            throw new NotFoundException($"Sorry, we could not find your item with id: {id}");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex,
                $"Error! {nameof(BaseController<TModel, TService>)}, Method: {nameof(Get)} Error: {ex} \nInnerException: {ex.InnerException}");

            throw new Exception("Sorry, we have a problem with the process of your request. Error information:", ex);
        }
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] TModel model)
    {
        try
        {
            var id = await _service.Add(model);
            return Created($"/api/{nameof(BaseController<TModel, TService>)}/{id}", null);
        }
        catch (Exception e)
        {
            _logger.LogError(e,
                $"Error! {nameof(BaseController<TModel, TService>)}, Method: {nameof(Create)} Error: {e} \nInnerException: {e.InnerException}");

            return StatusCode(500);
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        try
        {
            await _service.Delete(id);
            return NoContent();
        }
        catch (NotFoundException e)
        {
            _logger.LogError(e,
                $"Error! {nameof(BaseController<TModel, TService>)}, Method: {nameof(Delete)} Error: {e} \nInnerException: {e.InnerException}");

            return NotFound();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex,
                $"Error! {nameof(BaseController<TModel, TService>)}, Method: {nameof(Delete)} Error: {ex} \nInnerException: {ex.InnerException}");

            return StatusCode(500);
        }
    }
}