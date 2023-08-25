using BusinessLogicLayer.Services;
using DatabaseConnection.Models.Entity;
using Microsoft.AspNetCore.Mvc;

namespace BusinessLogicLayer.Contollers;

public class NoteController : ControllerBase
{
    private readonly IDashboardService _dashboardService;

    public NoteController(IDashboardService dashboardService)
    {
        _dashboardService = dashboardService;
    }

    [HttpGet]
    public List<Dashboard> GetAll()
    {
        var allDashboard = _dashboardService.GetAll();
        return allDashboard;
    }
    
    [HttpGet("{id}")]
    public Dashboard Get([FromRoute] Guid id)
    {
        var dashboard = _dashboardService.GetById(id);
        return dashboard;
    }

    [HttpPost]
    public ActionResult CreateDasboard([FromBody] Dashboard dashboard)
    {
        var id = _dashboardService.Add(dashboard);
        return Created("", null);
    }
    
    [HttpDelete("{id}")]
    public Dashboard Delete([FromRoute] Guid id)
    {
        var dashboard = _dashboardService.Delete(id);
        return dashboard;
    }
}