
using LAB11_WilliansMalque.Application.Tickets.Commands;
using LAB11_WilliansMalque.Application.Tickets.Querys;
using LAB11_WilliansMalque.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LAB11_WilliansMalque.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TicketsController : ControllerBase
{
    private readonly IMediator _mediator;

    public TicketsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateTicketCommand command)
    {
        var ticketId = await _mediator.Send(command);
        return Ok(new { ticketId });
    }
    
    [HttpGet]
    public async Task<ActionResult<List<Ticket>>> GetAllTickets()
    {
        var result = await _mediator.Send(new GetAllTicketsQuery());
        return Ok(result);
    }
}