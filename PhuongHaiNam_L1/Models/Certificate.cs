using System;
using System.Collections.Generic;

namespace PhuongHaiNam_L1.Models;

public partial class Certificate
{
    public int CertificateId { get; set; }

    public int EmployeeId { get; set; }

    public virtual Employee Employee { get; set; } = null!;
}
