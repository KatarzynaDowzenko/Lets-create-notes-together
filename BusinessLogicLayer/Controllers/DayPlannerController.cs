using BusinessLogicLayer.Services;
using DataAccessLayer.Models.BusinessModels;

namespace BusinessLogicLayer.Controllers;

public class DayPlannerController : BaseController<DayPlanner, DayPlannerService>
{
    public DayPlannerController(DayPlannerService service,
        ILogger<BaseController<DayPlanner, DayPlannerService>> logger) : base(service, logger)
    {
    }
}