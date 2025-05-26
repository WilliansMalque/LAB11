﻿using LAB11_WilliansMalque.Infrastructure.Data.Models;

namespace LAB11_WilliansMalque.Infrastructure.Models;

public partial class response
{
    public Guid response_id { get; set; }

    public Guid ticket_id { get; set; }

    public Guid responder_id { get; set; }

    public string message { get; set; } = null!;

    public DateTime? created_at { get; set; }

    public virtual user responder { get; set; } = null!;

    public virtual ticket ticket { get; set; } = null!;
}
