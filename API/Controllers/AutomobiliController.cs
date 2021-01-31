using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Automobili;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AutomobiliController : ControllerBase
    {
        private readonly IMediator mediator;
        public AutomobiliController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<List<AutomobilDTO>>> List(CancellationToken ct)
        {
            return await this.mediator.Send(new List.Query());
        }

        [HttpGet("{id}")]
        [Authorize]
        [AllowAnonymous]
        public async Task<ActionResult<AutomobilDTO>> Details(Guid id)
        {
            return await this.mediator.Send(new Details.Query{Id = id});
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<Unit>> Create(Create.Command command)
        {
            return await this.mediator.Send(command);
        }
        [HttpPut("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<Unit>> Update(Guid id, Update.Command command)
        {
            command.Id = id;
            return await this.mediator.Send(command);
        }
        [HttpDelete("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<Unit>> Delete(Guid id)
        {
            return await this.mediator.Send(new Delete.Command{Id=id});
        }
    }
}