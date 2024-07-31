using System;
using System.Collections.Generic;

namespace HandsOnEFDBFirst.Entities;

public partial class VwEmDept1
{
    public int Empid { get; set; }

    public string? EmployeeName { get; set; }

    public string? Designation { get; set; }

    public string DeptName { get; set; } = null!;
}
