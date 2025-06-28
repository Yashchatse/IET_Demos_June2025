using System;
using System.Collections.Generic;

namespace _16Demo_WebAPI.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string EmployeeName { get; set; } = null!;

    public int? DepartmentId { get; set; }

    public virtual Department? Department { get; set; }
}
