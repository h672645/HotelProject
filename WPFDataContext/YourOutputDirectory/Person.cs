using System;
using System.Collections.Generic;

namespace WPFDataContext.YourOutputDirectory;

public partial class Person
{
    public int PersonId { get; set; }

    public string? Fornavn { get; set; }

    public string? Etternavn { get; set; }

    public virtual Admin? Admin { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual Guest? Guest { get; set; }
}
