using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace SimpleLogin.Middleware
{
    public class CustomMiddleware : IMiddleware
    {
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            //Middleware to do work on roles
            return next(context);
        }
    }
}