using System;
using System.Collections.Generic;

namespace Altic_Shaw_Net6_Api.Entities;

public partial class WebAction
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual ICollection<RoleAction> RoleActions { get; set; } = new List<RoleAction>();
}
