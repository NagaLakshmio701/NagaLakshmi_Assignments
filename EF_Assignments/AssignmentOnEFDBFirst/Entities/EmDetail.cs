using System;
using System.Collections.Generic;

namespace HandsOnEFDBFirst.Entities;

public partial class EmDetail
{
    public int EmpId { get; set; }

    public string? EmployeeName { get; set; }

    public string? DeptCode { get; set; }

    public string? Designation { get; set; }

    public DateOnly? Joindate { get; set; }

    public virtual Department? DeptCodeNavigation { get; set; }
}
