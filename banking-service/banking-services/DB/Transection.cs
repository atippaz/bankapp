using System;
using System.Collections.Generic;

namespace banking_service.DB;

public partial class Transection
{
    public Guid TransectionId { get; set; }

    public Guid TransectionOwner { get; set; }

    public string TransectionType { get; set; } = null!;

    public DateTime TransectionDate { get; set; }

    public int TransectionBalance { get; set; }

    public Guid? TransectionUserReferrence { get; set; }

    public int TransectionAmount { get; set; }
}
