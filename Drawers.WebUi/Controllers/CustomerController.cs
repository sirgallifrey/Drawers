using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Drawers.Application.Customers.Commands.CreateCustomer;
using Drawers.Application.Customers.Queries.GetCustomersList;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Drawers.WebUi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController: ControllerBase
    {
        private IMediator _mediator;

        public CustomersController(IMediator mediator) {
            _mediator = mediator;
        }
        // GET api/customers
        [HttpGet]
        public async Task<ActionResult<CustomersListViewModel>> GetAll()
        {
            return Ok(await _mediator.Send(new GetCustomersListQuery()));
        }

        // GET api/customers/5
        // [HttpGet("{id}")]
        // public async Task<IActionResult> Get(string id)
        // {
        //     return Ok(await Mediator.Send(new GetCustomerDetailQuery { Id = id }));
        // }

        // POST api/customers
        [HttpPost]
        public async Task<IActionResult> Create([FromBody]CreateCustomerCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        // // PUT api/customers/5
        // [HttpPut("{id}")]
        // public async Task<IActionResult> Update(string id, [FromBody]UpdateCustomerCommand command)
        // {
        //     if (command == null || command.Id != id)
        //     {
        //         return BadRequest();
        //     }

        //     return Ok(await Mediator.Send(command));
        // }

        // // DELETE api/customers/5
        // [HttpDelete("{id}")]
        // public async Task<IActionResult> Delete(string id)
        // {
        //     await Mediator.Send(new DeleteCustomerCommand { Id = id });

        //     return NoContent();
        // }
    }
}
