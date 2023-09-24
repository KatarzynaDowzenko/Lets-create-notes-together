using BusinessLogicLayer.Services;
using DataAccessLayer.Models.BusinessModels;

namespace BusinessLogicLayer.Controllers;

public class NoteController : BaseController<Note, NoteService>
{
    public NoteController(NoteService service,
        ILogger<BaseController<Note, NoteService>> logger) : base(service, logger)
    {
    }
}