using System;
using System.Collections.Generic;

namespace HotelClasses.NET.YourOutputDirectory;

public partial class HotelRoom
{
    public int RoomId { get; set; }

    public int? NumberOfBeds { get; set; }

    public int? SizeOfRoom { get; set; }

    public string? QualityOfRoom { get; set; }

    public bool? Occupied { get; set; }

    public virtual ICollection<HotelReservation> HotelReservations { get; set; } = new List<HotelReservation>();
}
