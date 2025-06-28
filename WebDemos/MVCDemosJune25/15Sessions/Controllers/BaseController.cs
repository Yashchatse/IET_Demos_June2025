using _15Sessions.Filters;
using Microsoft.AspNetCore.Mvc;

namespace _15Sessions.Controllers
{
    [Auth]
    [SunbeamLogFilter]
    public abstract class BaseController : Controller
    {
    }
}
