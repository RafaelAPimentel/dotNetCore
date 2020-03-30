using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Middleware
{
    public class NumberCheckerMiddleware
    {
        private readonly RequestDelegate next;
        public NumberCheckerMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var value = context.Request.Query["value"].ToString();
            if (int.TryParse(value, out int intvalue))
            {
                await context.Response.WriteAsync($"You entered a number: {intvalue}");
            }
            else
            {
                context.Items["value"] = value;
                await next(context);
            }
        }
    }
}
