using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;

namespace API.Controllers
{

    public class RentPropertyController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RentPropertyController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }
    }
}
