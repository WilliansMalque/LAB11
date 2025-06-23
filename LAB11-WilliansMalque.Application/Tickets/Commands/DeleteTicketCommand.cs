using MediatR;

namespace LAB11_WilliansMalque.Application.Tickets.Commands;

public class DeleteTicketCommand : IRequest<bool>
{
    public Guid TicketId { get; set; }
}