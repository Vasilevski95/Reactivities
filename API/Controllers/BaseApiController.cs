using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //localhost:5000/weatherforecast
    public class BaseApiController : ControllerBase
    {
        private IMediator _mediator; //private means it can be used in this class

        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>(); //protected means it can be used by this class and any other derived classes
        //meaning of ??= if left from it is null then assign anything to the right to Mediator property
    }
}
