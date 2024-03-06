using System;
using System.Collections.Generic;

namespace banking_service.DB;

public partial class User
{
    public Guid UserId { get; set; }

    public string UserName { get; set; } = null!;

    public DateOnly UserBirthday { get; set; }

    public int UserBalance { get; set; }

    public string UserLastname { get; set; } = null!;

    public string UserUsername { get; set; } = null!;

    public string UserPassword { get; set; } = null!;

    public sbyte IsEnable { get; set; }

    public DateTime? UserCreatedDate { get; set; }
}
