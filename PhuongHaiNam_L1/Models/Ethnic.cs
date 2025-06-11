using System;
using System.Collections.Generic;

namespace PhuongHaiNam_L1.Models;

public partial class Ethnic
{
    public int EthnicId { get; set; }

    public string EthnicName { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
