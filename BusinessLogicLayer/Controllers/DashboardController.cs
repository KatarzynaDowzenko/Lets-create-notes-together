using BusinessLogicLayer.Services;
using DataAccessLayer.Models.BusinessModels;

namespace BusinessLogicLayer.Controllers;

public class DashboardController : BaseController<Dashboard, DashboardService>
{
    public DashboardController(DashboardService service,
        ILogger<BaseController<Dashboard, DashboardService>> logger) : base(service, logger)
    {
    }
}