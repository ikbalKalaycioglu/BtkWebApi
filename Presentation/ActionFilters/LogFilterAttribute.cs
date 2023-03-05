using Entites.LogModal;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.ActionFilters
{
    public class LogFilterAttribute :ActionFilterAttribute
    {
        private readonly ILoggerService _looger;

        public LogFilterAttribute(ILoggerService looger)
        {
            _looger = looger;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            _looger.LogInfo(Log("OnActionExecuting", context.RouteData));
        }

        private string Log(string modelName, RouteData routeData)
        {
            var logDetails = new LogDetails()
            {
                ModalName = modelName,
                Controller = routeData.Values["controller"],
                Action = routeData.Values["action"],
            };

            if(routeData.Values.Count >= 3)
            {
                logDetails.Id = routeData.Values["Id"];
            }
            return logDetails.ToString();
        }
    }
}
