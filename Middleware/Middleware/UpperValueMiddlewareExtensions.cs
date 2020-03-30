using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Middleware
{
    public static class UpperValueMiddlewareExtensions
    {
        public static IApplicationBuilder UseUpperValue(this IApplicationBuilder app)
        {
            return app.UseMiddleware<UpperValueMiddleware>();
        }
    }
}
