using System;
using System.Collections.Generic;

namespace PhuongHaiNam_L1.Models;

public partial class Ward
{
    public int WardId { get; set; }

    public string WardName { get; set; } = null!;

    public int DistrictId { get; set; }

    public virtual District District { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
