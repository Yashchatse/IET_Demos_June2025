using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace _11Demo_Filters.Filter
{
    public class DynamicLayoutFilter : Attribute, IResultFilter
    {
        public void OnResultExecuting(ResultExecutingContext context)
        {
            if (context.Controller is Controller controller)
            {
                var actionName = context.RouteData.Values["action"].ToString();
                if (actionName == "About")
                {
                    controller.ViewData["Layout1"] = "~/Views/Shared/_Layout1.cshtml";
                    controller.ViewData["OnResultExecuting"] = "Result Execution started...";
                }
            }
        }

        public void OnResultExecuted(ResultExecutedContext context)
        {
            context.HttpContext.Response.WriteAsync("Result Execution stopped...");
        }
    }
}
