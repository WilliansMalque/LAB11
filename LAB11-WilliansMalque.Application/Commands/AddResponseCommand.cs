using MediatR;
using System;

namespace LAB11_WilliansMalque.Application.Commands
{
    public class AddResponseCommand : IRequest<Guid>
    {
        public Guid TicketId { get; set; }
        public Guid ResponderId { get; set; }
        public string Message { get; set; } = null!;
    }
}