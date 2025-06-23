namespace LAB11_WilliansMalque.Domain.Entities;

public class Ticket
{
    public Guid Id { get; set; }                      // Corresponde a ticket_id en BD
    public Guid UserId { get; set; }                  // Necesario para mapear user_id de la BD
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string Status { get; set; } = "abierto";
    public DateTime CreatedAt { get; set; }
    public DateTime? ClosedAt { get; set; }
}