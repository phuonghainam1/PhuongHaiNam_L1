using System;
using System.Collections.Generic;

namespace PhuongHaiNam_L1.Models;

public partial class Job
{
    public int JobId { get; set; }

    public string JobName { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
