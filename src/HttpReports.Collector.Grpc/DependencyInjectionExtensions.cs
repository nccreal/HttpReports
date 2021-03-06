using HttpReports;
using HttpReports.Collector.Grpc;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Extensions.DependencyInjection 
{
    public static class DependencyInjectionExtensions
    {
        public static IHttpReportsBuilder AddGrpcCollector(this IHttpReportsBuilder builder)
        {
            builder.Services.AddGrpc();
            return builder;
        }

        public static GrpcServiceEndpointConventionBuilder MapGrpcCollector(this IEndpointRouteBuilder builder)
        {
            return builder.MapGrpcService<GrpcCollectorService>();
        }
    }
}
