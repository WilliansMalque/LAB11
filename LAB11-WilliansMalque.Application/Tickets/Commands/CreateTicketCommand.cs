using MediatR;

namespace LAB11_WilliansMalque.Application.Tickets.Commands;

public record CreateTicketCommand(string Title, string Description, Guid UserId) : IRequest<Guid>;