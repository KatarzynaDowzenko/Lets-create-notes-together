using BusinessLogicLayer.Models;
using BusinessLogicLayer.Services;
using Microsoft.AspNetCore.Mvc;

namespace BusinessLogicLayer.Controllers;

public class CheckListController :BaseController<CheckList, CheckListService>
{
    public CheckListController(CheckListService service, ILogger<BaseController<CheckList, CheckListService>> logger) : base(service, logger)
    {
    }
}