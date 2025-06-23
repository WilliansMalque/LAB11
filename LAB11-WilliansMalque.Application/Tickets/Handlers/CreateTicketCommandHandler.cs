using LAB11_WilliansMalque.Application.Tickets.Commands;
using LAB11_WilliansMalque.Infrastructure.Data;
using LAB11_WilliansMalque.Infrastructure.Models;
using MediatR;

namespace LAB11_WilliansMalque.Application.Tickets.Handlers;

public class CreateTicketCommandHandler : IRequestHandler<CreateTicketCommand, Guid>
{
    private readonly AppDbContext _context;

    public CreateTicketCommandHandler(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Guid> Handle(CreateTicketCommand request, CancellationToken cancellationToken)
    {
        var newTicket = new ticket
        {
            ticket_id = Guid.NewGuid(),
            title = request.Title,
            description = request.Description,
            user_id = request.UserId,
            status = "abierto",
            created_at = DateTime.UtcNow
        };

        _context.tickets.Add(newTicket);
        await _context.SaveChangesAsync(cancellationToken);

        return newTicket.ticket_id;
    }
}