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
        /// ����ִ�н���
        /// </summary>
        /// <param name="context"></param>
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine(1);
            base.OnActionExecuted(context);
        }
        /// <summary>
        /// ����ִ����
        /// </summary>
        /// <param name="context"></param>
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine(2);
            base.OnActionExecuting(context);
        }
        /// <summary>
        /// ��������ִ����
        /// </summary>
        /// <param name="context"></param>
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            Console.WriteLine(3);
            context.Result = new JsonResult(new List<string>() { "a" });
            base.OnResultExecuting(context);
        }
        /// <summary>
        /// �����Ѿ�����
        /// </summary>
        /// <param name="context"></param>
        public override void OnResultExecuted(ResultExecutedContext context)
        {
            Console.WriteLine(4);
            base.OnResultExecuted(context);
        }
    }
}