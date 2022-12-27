using System;
using System.Collections.Generic;

namespace Backendslap.Models;

public partial class Slaptable
{
    public int Slapid { get; set; }

    public string? SlapName { get; set; }

    public string? PayGroupCode { get; set; }

    public string? SlapLowValue { get; set; }

    public string? SlapHighValue { get; set; }

    public double? SlapPercentage { get; set; }

    public string? SlapValue { get; set; }
}
