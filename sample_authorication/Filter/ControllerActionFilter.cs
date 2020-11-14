using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace sample_authorication
{
    /// <summary>
    /// 
    /// </summary>
    public class ControllerActionFilter: ActionFilterAttribute
    {
        /// <summary>
        /// 动作执行结束
        /// </summary>
        /// <param name="context"></param>
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine(1);
            base.OnActionExecuted(context);
        }
        /// <summary>
        /// 动作执行中
        /// </summary>
        /// <param name="context"></param>
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine(2);
            base.OnActionExecuting(context);
        }
        /// <summary>
        /// 动作结束执行中
        /// </summary>
        /// <param name="context"></param>
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            Console.WriteLine(3);
            context.Result = new JsonResult(new List<string>() { "a" });
            base.OnResultExecuting(context);
        }
        /// <summary>
        /// 动作已经结束
        /// </summary>
        /// <param name="context"></param>
        public override void OnResultExecuted(ResultExecutedContext context)
        {
            Console.WriteLine(4);
            base.OnResultExecuted(context);
        }
    }
}