using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace _15Sessions.Filters
{
    public class SunbeamLogFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Logger.CurrentLogger.Log(string.Format("{0}/{1} is called.",
                        context.ActionDescriptor.RouteValues["Controller"],
                        context.ActionDescriptor.RouteValues["Action"]));
        }
    }
}
