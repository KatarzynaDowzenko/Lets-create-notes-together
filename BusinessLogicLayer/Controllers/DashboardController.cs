using BusinessLogicLayer.Models;
using BusinessLogicLayer.Services;
using Microsoft.AspNetCore.Mvc;

namespace BusinessLogicLayer.Controllers;

public class DashboardController : BaseController<Dashboard, DashboardService>
{
    public DashboardController(DashboardService service, ILogger<BaseController<Dashboard, DashboardService>> logger) : base(service, logger)
    {
    }
}