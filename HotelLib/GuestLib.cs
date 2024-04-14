

namespace GuestLib
{
    public class Guest
    {
        private string Navn { get; set; }  
        private string Etternavn { get; set; }  
        public Guest(string Navn, string Etternavn) {
            this.Navn = Navn;
            this.Etternavn = Etternavn;
        }
    }
}
