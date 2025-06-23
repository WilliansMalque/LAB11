using LAB11_WilliansMalque.Application.Tickets.Commands;
using LAB11_WilliansMalque.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LAB11_WilliansMalque.Application.Tickets.Handlers
{
    public class UpdateTicketStatusCommandHandler : IRequestHandler<UpdateTicketStatusCommand, bool>
    {
        private readonly AppDbContext _context;

        public UpdateTicketStatusCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(UpdateTicketStatusCommand request, CancellationToken cancellationToken)
        {
            var ticket = await _context.tickets
                .FirstOrDefaultAsync(t => t.ticket_id == request.TicketId, cancellationToken);

            if (ticket == null) return false;

            // Validar estado permitido
            var validStatuses = new[] { "abierto", "en_proceso", "cerrado" };
            if (!validStatuses.Contains(request.NewStatus)) return false;

            ticket.status = request.NewStatus;

            if (request.NewStatus == "cerrado")
                ticket.closed_at = DateTime.UtcNow;

            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}