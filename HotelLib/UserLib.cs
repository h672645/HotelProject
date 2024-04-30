

namespace UserLib
{
    public class Person
    {
        public string Navn { get; set; }

        public string Etternavn { get; set; }

        public Person(string navn, string etternavn)
        {
            this.Navn = navn;
            this.Etternavn = etternavn;
        }

    }

    public class Guest : Person
    {
        public Guest(string Navn, string Etternavn) : base(Navn, Etternavn) {
            this.Navn = Navn;
            this.Etternavn = Etternavn;
        }
    }

    public class Employee : Person
    {
        private String Stilling {  get; set; }
        public Employee(string Navn, string Etternavn, string Stilling) : base(Navn, Etternavn)
        {
            this.Stilling = Stilling;
        }

    }

    public class Admin : Person
    {
        public Admin(string Navn, String etternavn) : base(Navn, etternavn) 
        {
            
        }
    }
}
