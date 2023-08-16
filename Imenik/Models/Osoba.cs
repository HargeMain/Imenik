using System.ComponentModel.DataAnnotations;

namespace Imenik.Models
{
    public class Osoba
    {
        [Key]
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojTelefona { get; set; }
        public string Pol { get; set; }
        public string Email { get; set; }
        public int GradId { get; set; }

        public int DrzavaId { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public int Starost { get; set; }

        public Grad Grad { get; set; }

        public Drzava Drzava { get; set; }

        


        private int RacGod(DateTime dateOfBirth)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dateOfBirth.Year;
            if (dateOfBirth.Date > today.AddYears(-age))
                age--;
            return age;
        }
    }

}

