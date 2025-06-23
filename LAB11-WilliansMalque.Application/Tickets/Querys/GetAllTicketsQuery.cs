using LAB11_WilliansMalque.Domain.Entities;
using MediatR;

namespace LAB11_WilliansMalque.Application.Tickets.Querys
{
    public class GetAllTicketsQuery : IRequest<List<Ticket>> { }
}