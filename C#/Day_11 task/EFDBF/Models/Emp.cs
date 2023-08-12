using System;
using System.Collections.Generic;

namespace EFDBF.Models;

public partial class Emp
{
    public int Empno { get; set; }

    public string? Empname { get; set; }

    public int? Deptno { get; set; }

    public string? Address { get; set; }

    public virtual Dept? DeptnoNavigation { get; set; }
}
