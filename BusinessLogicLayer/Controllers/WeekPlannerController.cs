using BusinessLogicLayer.Services;
using DataAccessLayer.Models.BusinessModels;

namespace BusinessLogicLayer.Controllers;

public class WeekPlannerController : BaseController<WeekPlanner, WeekPlannerService>
{
    public WeekPlannerController(WeekPlannerService service,
        ILogger<BaseController<WeekPlanner, WeekPlannerService>> logger) : base(service, logger)
    {
    }
}