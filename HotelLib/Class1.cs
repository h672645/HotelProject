namespace HotelLib
{
    public class HotelRoom
    {
        private int Id {  get; set; }

        private int NumberOfBeds {  get; set; }

        private int SizeOfRoom { get; set; }

        private string QualityOfRoom { get; set; }

        public HotelRoom(int  NumberOfBeds, int SizeOfRoom, string QualityOfRoom)
        {
            this.NumberOfBeds = NumberOfBeds;
            this.SizeOfRoom = SizeOfRoom;
            this.QualityOfRoom = QualityOfRoom;
        }
    }
}
