using System;
using System.Collections.Generic;

namespace AreasWithUserWiseDynamicMenus.Models;

public partial class Tbluser
{
    public int UserId { get; set; }

    public string? FullName { get; set; }

    public int? RoleId { get; set; }

    public string UserName { get; set; } = null!;

    public string? Password { get; set; }

    public virtual Tblrole? Role { get; set; }
}
