using Microsoft.AspNetCore.Builder;
using MiddlewareDemo.Middleware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareDemo
{
    public static class MiddleWareExtensions
    {
        public static IApplicationBuilder UseRequestIp(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestIpMiddleware>();
        }
    }
}
