using BusinessLogicLayer.Models;
using BusinessLogicLayer.Services;
using Microsoft.AspNetCore.Mvc;

namespace BusinessLogicLayer.Controllers;

public class DayPlannerController : BaseController<DayPlanner, DayPlannerService>
{
    public DayPlannerController(DayPlannerService service, ILogger<BaseController<DayPlanner, DayPlannerService>> logger) : base(service, logger)
    {
    }
}