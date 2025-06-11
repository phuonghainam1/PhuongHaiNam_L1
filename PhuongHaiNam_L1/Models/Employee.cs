using System;
using System.Collections.Generic;

namespace PhuongHaiNam_L1.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public int EthnicId { get; set; }

    public int JobId { get; set; }

    public int CityId { get; set; }

    public int DistrictId { get; set; }

    public int WardId { get; set; }

    public virtual ICollection<Certificate> Certificates { get; set; } = new List<Certificate>();

    public virtual City City { get; set; } = null!;

    public virtual District District { get; set; } = null!;

    public virtual Ethnic Ethnic { get; set; } = null!;

    public virtual Job Job { get; set; } = null!;

    public virtual Ward Ward { get; set; } = null!;
}
