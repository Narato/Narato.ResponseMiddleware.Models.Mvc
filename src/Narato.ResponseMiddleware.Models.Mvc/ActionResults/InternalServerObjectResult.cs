using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Narato.ResponseMiddleware.Models.Mvc.ActionResults
{
    public class InternalServerObjectResult : ObjectResult
    {
        public InternalServerObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status500InternalServerError;
        }
    }
}
