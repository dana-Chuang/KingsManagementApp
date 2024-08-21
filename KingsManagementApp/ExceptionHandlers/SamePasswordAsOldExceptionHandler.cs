using Microsoft.AspNetCore.Diagnostics;
using System.ComponentModel.DataAnnotations;

namespace KingsManagementApp.ExceptionHandlers
{
    public class SamePasswordAsOldExceptionHandler(ILogger<SamePasswordAsOldExceptionHandler> logger) : IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            if (exception is ValidationException e)
            {
                httpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                await httpContext.Response.WriteAsJsonAsync(e.ValidationResult, cancellationToken);

                return true;
            }
            return false;
        }
    }
}
