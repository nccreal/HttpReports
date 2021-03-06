using HttpReports;
using HttpReports.Transport.Grpc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;  

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyInjectionExtensions
    { 
        public static IHttpReportsBuilder AddGrpcTransport(this IHttpReportsBuilder builder)
        {
            builder.Services.AddOptions().Configure<GrpcTransportOptions>(builder.Configuration.GetSection("Transport"));
            return builder.AddGrpcTransportService();
        }

        public static IHttpReportsBuilder AddGrpcTransport(this IHttpReportsBuilder builder, Action<GrpcTransportOptions> options)
        {
            builder.Services.AddOptions().Configure(options);
            return builder.AddGrpcTransportService();
        }

        private static IHttpReportsBuilder AddGrpcTransportService(this IHttpReportsBuilder builder)
        { 
            builder.Services.RemoveAll<IReportsTransport>();
            builder.Services.AddSingleton<IReportsTransport,GrpcTransport>();
            return builder;
        }


        [Obsolete("Use AddGrpcTransport instead")]
        public static IHttpReportsBuilder UseGrpcTransport(this IHttpReportsBuilder builder)
        {
            builder.Services.AddOptions().Configure<GrpcTransportOptions>(builder.Configuration.GetSection("Transport"));
            return builder.AddGrpcTransportService();
        }


        [Obsolete("Use AddGrpcTransport instead")]
        public static IHttpReportsBuilder UseGrpcTransport(this IHttpReportsBuilder builder, Action<GrpcTransportOptions> options)
        {
            builder.Services.AddOptions().Configure(options);
            return builder.AddGrpcTransportService();
        }
         
    }
}
