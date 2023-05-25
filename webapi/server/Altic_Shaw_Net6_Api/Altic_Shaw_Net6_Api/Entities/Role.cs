using System;
using System.Collections.Generic;

namespace Altic_Shaw_Net6_Api.Entities;

public partial class Role
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<RoleAction> RoleActions { get; set; } = new List<RoleAction>();

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}
