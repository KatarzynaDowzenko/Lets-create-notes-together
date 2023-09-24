using BusinessLogicLayer.Models;
using BusinessLogicLayer.Services;

namespace BusinessLogicLayer.Controllers;

public class CalenderController : BaseController<Calender, CalenderService>
{
    public CalenderController(CalenderService service,
        ILogger<BaseController<Calender, CalenderService>> logger) : base(service, logger)
    {
    }
}