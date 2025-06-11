using System;
using System.Collections.Generic;

namespace PhuongHaiNam_L1.Models;

public partial class City
{
    public int CityId { get; set; }

    public string CityName { get; set; } = null!;

    public virtual ICollection<District> Districts { get; set; } = new List<District>();

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
