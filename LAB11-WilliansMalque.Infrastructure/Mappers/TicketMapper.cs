using LAB11_WilliansMalque.Domain.Entities;
using LAB11_WilliansMalque.Infrastructure.Models;

namespace LAB11_WilliansMalque.Infrastructure.Mappers;

public static class TicketMapper
{
    public static Ticket ToDomain(this ticket entity)
    {
        return new Ticket
        {
            Id = entity.ticket_id,
            UserId = entity.user_id,
            Title = entity.title,
            Description = entity.description,
            Status = entity.status,
            CreatedAt = entity.created_at ?? DateTime.UtcNow,
            ClosedAt = entity.closed_at
        };
    }

    public static ticket ToInfrastructure(this Ticket domain)
    {
        return new ticket
        {
            ticket_id = domain.Id,
            user_id = domain.UserId,
            title = domain.Title,
            description = domain.Description,
            status = domain.Status,
            created_at = domain.CreatedAt,
            closed_at = domain.ClosedAt
            // No seteamos user ni responses porque no se usan en alta
        };
    }
}