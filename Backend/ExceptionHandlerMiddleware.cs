using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Backend
{
    public class ExceptionHandlerMiddleware
    {
        /// <summary>
        /// 
        /// </summary>
        public class ExceptionHandleMiddleware
        {
            private readonly RequestDelegate _next;

            public ExceptionHandleMiddleware(RequestDelegate next)
            {
                _next = next;
            }

            /// <summary>
            /// 
            /// </summary>
            public async Task InvokeAsync(HttpContext context)
            {
                try
                {
                    await _next(context);
                }
                catch (Exception ex)
                {
                   context.Response.ContentType = "application/json";
                   context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                   await context.Response.WriteAsync(JsonSerializer.Serialize($"{{ MiddlewareCatchedError : {ex.Message} }}"));
                }
            }
        }
    }
}
