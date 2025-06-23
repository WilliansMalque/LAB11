using LAB11_WilliansMalque.Application.Tickets.Querys;
using LAB11_WilliansMalque.Domain.Entities;
using LAB11_WilliansMalque.Infrastructure.Data;
using LAB11_WilliansMalque.Infrastructure.Mappers;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LAB11_WilliansMalque.Application.Tickets.Handlers
{
    public class GetAllTicketsQueryHandler : IRequestHandler<GetAllTicketsQuery, List<Ticket>>
    {
        private readonly AppDbContext _context;

        public GetAllTicketsQueryHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Ticket>> Handle(GetAllTicketsQuery request, CancellationToken cancellationToken)
        {
            var tickets = await _context.tickets
                .AsNoTracking()
                .ToListAsync(cancellationToken);

            return tickets.Select(t => t.ToDomain()).ToList();
        }
    }
}