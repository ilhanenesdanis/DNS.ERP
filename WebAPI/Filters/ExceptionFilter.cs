using Microsoft.AspNetCore.Mvc.Filters;

namespace WebAPI.Filters
{
    public class ExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        { }
    }
}
