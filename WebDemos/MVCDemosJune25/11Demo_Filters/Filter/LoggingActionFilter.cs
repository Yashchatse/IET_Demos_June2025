using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace _11Demo_Filters.Filter
{
    public class LoggingActionFilter :Attribute, IActionFilter
    {
        private Stopwatch _stopwatch;
        public void OnActionExecuting(ActionExecutingContext context)
        {
            _stopwatch = Stopwatch.StartNew();
            if(context.Controller is Controller controller)
            {
                controller.ViewData["ActionFilterMessage"] = "Action Filter Executed";
            }
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            _stopwatch.Stop();
            var timeTaken = _stopwatch.ElapsedTicks;
            if (context.Controller is Controller controller)
            {
                controller.ViewData["ElapsedTicks"] = $"Time Taken : {timeTaken} ticks";
                controller.ViewData["OnActionExecuted"] = "Action Execution Stopped";
            }
        }

        
    }
}
