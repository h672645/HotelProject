using System;
using System.Collections.Generic;

namespace WPFDataContext.YourOutputDirectory;

public partial class HotelRoom
{
    public int RoomId { get; set; }

    public int? NumberOfBeds { get; set; }

    public int? SizeOfRoom { get; set; }

    public string? QualityOfRoom { get; set; }

    public bool? Occupied { get; set; }

    public virtual ICollection<HotelReservation> HotelReservations { get; set; } = new List<HotelReservation>();

    public string sjekk(DateTime StartDate, DateTime EndDate)
    {
        return IsReservationActive(StartDate, EndDate) == true ? $"Opptatt" : $"Ledig";
    }

    public string sjekk()
    {
        return Occupied == true ? $"Opptatt" : $"Ledig";
    }
    private bool IsReservationActive(DateTime StartDate, DateTime EndDate)
    {
        DateTime dagensDato = DateTime.Now;

        if (this == null)
        {
            return false;
        }

        if (dagensDato >= StartDate && dagensDato < EndDate)
        {
            this.Occupied = true;
            return true;
        }

        this.Occupied = false;
        return false;
    }
    public override string ToString()
    {
        return $"Rom: {RoomId} \nNumberOfBeds: {NumberOfBeds} \nSize: {SizeOfRoom} \nQuality: {QualityOfRoom}";
    }
}
