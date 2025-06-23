using LAB11_WilliansMalque.Application.Tickets.Commands;
using LAB11_WilliansMalque.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LAB11_WilliansMalque.Application.Tickets.Handlers;

public class DeleteTicketCommandHandler : IRequestHandler<DeleteTicketCommand, bool>
{
    private readonly AppDbContext _context;

    public DeleteTicketCommandHandler(AppDbContext context)
    {
        _context = context;
    }

    public async Task<bool> Handle(DeleteTicketCommand request, CancellationToken cancellationToken)
    {
        var ticket = await _context.tickets
            .FirstOrDefaultAsync(t => t.ticket_id == request.TicketId, cancellationToken);

        if (ticket == null)
            return false;

        _context.tickets.Remove(ticket);
        await _context.SaveChangesAsync(cancellationToken);

        return true;
    }
}