using BusinessLogicLayer.Services;
using DataAccessLayer.Models.BusinessModels;

namespace BusinessLogicLayer.Controllers;

public class CalenderController : BaseController<Calender, CalenderService>
{
    public CalenderController(CalenderService service,
        ILogger<BaseController<Calender, CalenderService>> logger) : base(service, logger)
    {
    }
}