using System;
using System.Collections.Generic;

namespace Backendslap.Models;

public partial class SlapDefinition
{
    public int Slid { get; set; }

    public string? ShortName { get; set; }

    public string? PayGroupCode { get; set; }

    public string? DescriptionS { get; set; }

    public string? StatusS { get; set; }
}
