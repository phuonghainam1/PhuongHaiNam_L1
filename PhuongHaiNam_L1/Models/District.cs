using System;
using System.Collections.Generic;

namespace PhuongHaiNam_L1.Models;

public partial class District
{
    public int DistrictId { get; set; }

    public string DistrictName { get; set; } = null!;

    public int CityId { get; set; }

    public virtual City City { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual ICollection<Ward> Wards { get; set; } = new List<Ward>();
}
