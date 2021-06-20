﻿using Clinic.Core.CustomExceptions;
using Clinic.Infrastructure.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Clinic.Infrastructure.Filters
{
    public class GlobalExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var exceptionType = context.Exception.GetType();

            if(context.Exception is BusisnessException)
            {
                var exception = context.Exception as BusisnessException;

                var response = new BadRequestResponse
                {
                    Message = exception.Message,
                    Success = false
                };

                context.Result = new BadRequestObjectResult(response);
                context.HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
            }
        }
    }
}