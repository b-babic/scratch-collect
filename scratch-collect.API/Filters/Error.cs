using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using scratch_collect.API.Exceptions;
using System;
using System.Linq;
using System.Net;

namespace scratch_collect.API.Filters
{
    public class ErrorFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            switch (context.Exception)
            {
                case ArgumentNullException:
                    context.ModelState.AddModelError("Errors", context.Exception.Message);
                    context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                    break;

                case DbUpdateException:
                    context.ModelState.AddModelError("Errors", context.Exception.Message + ", or you can't delete records before deleting records in linked tables.");
                    context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                    break;

                case BadRequestException:
                    context.ModelState.AddModelError("Errors", context.Exception.Message);
                    context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                    break;

                default:
                    context.ModelState.AddModelError("Errors", "Server error!");
                    context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    break;
            }

            var list = context.ModelState
                .ToDictionary(x => x.Key ?? "default", y => y.Value.Errors.Select(z => z.ErrorMessage));

            context.Result = new JsonResult(list);
        }
    }
}