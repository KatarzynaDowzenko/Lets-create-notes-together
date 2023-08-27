using BusinessLogicLayer.Models;
using BusinessLogicLayer.Services;
using Microsoft.AspNetCore.Mvc;

namespace BusinessLogicLayer.Controllers;

public class WeekPlannerController : BaseController<WeekPlanner, WeekPlannerService>
{
    public WeekPlannerController(WeekPlannerService service, ILogger<BaseController<WeekPlanner, WeekPlannerService>> logger) : base(service, logger)
    {
    }
}