using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Middleware
{
    public static class SkipAppMiddlewareExtensions
    {
        public static IApplicationBuilder UseSkipApp(this IApplicationBuilder app)
        {
            return app.UseMiddleware<SkipAppMiddleware>();
        }
    }
}
