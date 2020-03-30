using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Middleware
{
    public static class VowelMaskerMiddlewareExtensions
    {
        public static IApplicationBuilder UseVowelMasker(this IApplicationBuilder app)
        {
            return app.UseMiddleware<VowelMaskerMiddleware>();
        }
    }
}
