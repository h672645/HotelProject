using UserLib;

namespace HotelLib
{
    public class Hotel
    {
        private string Navn {  get; set; }

        private string HotellKjede { get; set; }

        private string Beskrivelse { get; set; }



        private HotelRoom[] HotelRooms { get; set; }

        private HotelReservation[] HotelReservations { get; set; }



    }
    public class HotelRoom
    {
        private int Id {  get; set; }

        private int NumberOfBeds {  get; set; }

        private int SizeOfRoom { get; set; }

        private string QualityOfRoom { get; set; }

        public bool Occupied { get; set; }

        public HotelRoom(int  NumberOfBeds, int SizeOfRoom, string QualityOfRoom)
        {
            this.NumberOfBeds = NumberOfBeds;
            this.SizeOfRoom = SizeOfRoom;
            this.QualityOfRoom = QualityOfRoom;
            this.Occupied = false;
        }
    }

    public class HotelReservation
    {
        private int Id {  get; set; }
        private Guest Guest { get; set; }

        private DateTime StartDate { get; set; }

        private DateTime EndDate { get; set; }
        private HotelRoom HotelRoom { get; set; }

        public HotelReservation(Guest guest, HotelRoom hotelRoom, DateTime StartDate, DateTime EndDate, DateTime currentTime)
        {
            this.Guest = guest;
            this.HotelRoom = hotelRoom;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            IsReservationActive(currentTime);
        }

        public bool IsReservationActive(DateTime currentDate)
        {
            if (HotelRoom == null)
            {
                return false;
            }

            if (currentDate >= StartDate && currentDate < EndDate)
            {
                HotelRoom.Occupied = true;
                return true;
            }

            HotelRoom.Occupied = false;
            return false;
        }
    } 
}
