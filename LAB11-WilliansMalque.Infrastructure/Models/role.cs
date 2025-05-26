using System;
using System.Collections.Generic;

namespace LAB11_WilliansMalque.Infrastructure.Data.Models;

public partial class role
{
    public Guid role_id { get; set; }

    public string role_name { get; set; } = null!;

    public virtual ICollection<user_role> user_roles { get; set; } = new List<user_role>();
}
