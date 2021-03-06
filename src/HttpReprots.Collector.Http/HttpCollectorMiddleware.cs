using HttpReports;
using HttpReports.Core; 
using HttpReports.Core.Models;
using HttpReports.Storage.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives; 
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;

namespace HttpReprots.Collector.Http
{
    public class HttpCollectorMiddleware
    {
        private readonly RequestDelegate _next;

        public ILogger<HttpCollectorMiddleware> _logger; 

        public readonly IHttpReportsStorage _storage;

        private JsonSerializerOptions _jsonSetting;

        public HttpCollectorMiddleware(RequestDelegate next, IHttpReportsStorage storage, JsonSerializerOptions jsonSetting, ILogger<HttpCollectorMiddleware> logger)
        {
            _next = next;
            _logger = logger; 
            _jsonSetting = jsonSetting;
            _storage = storage;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            StringValues TransportType;

            if (!context.Request.Headers.TryGetValue(BasicConfig.TransportType, out TransportType))
            {
                context.Response.StatusCode = (int)HttpStatusCode.NotFound;

                return;
            } 

            using (var Reader = new StreamReader(context.Request.Body))
            {
                var body = await Reader.ReadToEndAsync();

                if (!body.IsEmpty())
                {
                    await Save(HttpUtility.HtmlDecode(body),TransportType.ToString());
                } 
            }

            await context.Response.WriteAsync("Collect Success"); 
        }


        private async Task Save(string Body,string TransportType)
        {
            if (TransportType == typeof(RequestBag).Name)
            {
                try
                {
                    var package = System.Text.Json.JsonSerializer.Deserialize<List<RequestBag>>(Body, _jsonSetting);

                    if (package != null && package.Any())
                    {
                        foreach (var item in package)
                        {
                            await _storage.AddRequestInfoAsync(item);
                        } 
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogWarning("Collector Failed:" + ex.Message); 
                } 
            }

            if (TransportType == typeof(Performance).Name)
            {
                try
                {
                    var package = System.Text.Json.JsonSerializer.Deserialize<Performance>(Body, _jsonSetting);

                    await _storage.AddPerformanceAsync(package);
                }
                catch (Exception ex)
                {
                    _logger.LogWarning("Collector Failed:" + ex.Message);
                } 
                
            }  
        }  
    }
}
