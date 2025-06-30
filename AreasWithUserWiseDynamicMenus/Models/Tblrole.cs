using System;
using System.Collections.Generic;

namespace AreasWithUserWiseDynamicMenus.Models;

public partial class Tblrole
{
    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public virtual ICollection<Tbluser> Tblusers { get; set; } = new List<Tbluser>();
}
