using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleMVC.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class ActionProfilerAttribute : FilterAttribute, IActionFilter
    {
        public bool Disable { get; set; }

        private Stopwatch timer;
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            timer.Stop();
            if (filterContext.Exception == null && !Disable)
            {
                string comment = string.Format(@"<!-- Action tog: {0} sekunder -->", timer.Elapsed.TotalSeconds.ToString("F6"));
                filterContext.HttpContext.Response.Write(comment);
            }
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            timer = Stopwatch.StartNew();
        }
    }
}

