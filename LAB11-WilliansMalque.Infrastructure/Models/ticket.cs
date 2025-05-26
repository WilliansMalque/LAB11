﻿using System;
using System.Collections.Generic;
using LAB11_WilliansMalque.Infrastructure.Models;

namespace LAB11_WilliansMalque.Infrastructure.Data.Models;

public partial class ticket
{
    public Guid ticket_id { get; set; }

    public Guid user_id { get; set; }

    public string title { get; set; } = null!;

    public string? description { get; set; }

    public string status { get; set; } = null!;

    public DateTime? created_at { get; set; }

    public DateTime? closed_at { get; set; }

    public virtual ICollection<response> responses { get; set; } = new List<response>();

    public virtual user user { get; set; } = null!;
}
