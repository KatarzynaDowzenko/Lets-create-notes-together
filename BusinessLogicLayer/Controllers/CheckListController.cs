using BusinessLogicLayer.Services;
using DataAccessLayer.Models.BusinessModels;

namespace BusinessLogicLayer.Controllers;

public class CheckListController : BaseController<CheckList, CheckListService>
{
    public CheckListController(CheckListService service,
        ILogger<BaseController<CheckList, CheckListService>> logger) : base(service, logger)
    {
    }
}