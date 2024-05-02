using System;
using System.Collections.Generic;

namespace HotelClasses.NET.YourOutputDirectory;

public partial class RoomService
{
    public int RoomId { get; set; }

    public string? Tjeneste { get; set; }

    public override string ToString()
    {
        return RoomId.ToString() + "er rommet (" + Tjeneste + ") /n";
    }
}
