﻿using System;
using System.Collections.Generic;

namespace LAB11_WilliansMalque.Infrastructure.Data.Models;

public partial class user_role
{
    public Guid user_id { get; set; }

    public Guid role_id { get; set; }

    public DateTime? assigned_at { get; set; }

    public virtual role role { get; set; } = null!;

    public virtual user user { get; set; } = null!;
}
