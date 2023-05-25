using System;
using System.Collections.Generic;

namespace Altic_Shaw_Net6_Api.Entities;

public partial class User
{
    public string Id { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}
