using MediatR;

namespace LAB11_WilliansMalque.Application.Tickets.Commands
{
    public class UpdateTicketStatusCommand : IRequest<bool>
    {
        public Guid TicketId { get; set; }
        public string NewStatus { get; set; } = null!;
    }
}