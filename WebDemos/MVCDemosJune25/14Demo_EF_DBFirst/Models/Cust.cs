using System;
using System.Collections.Generic;

namespace _14Demo_EF_DBFirst.Models;

public partial class Cust
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Bno { get; set; }
}
