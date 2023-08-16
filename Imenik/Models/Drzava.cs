using System.ComponentModel.DataAnnotations;

namespace Imenik.Models
{
    public class Drzava
    {
        [Key]
        public int Id { get; set; }
        public string Naziv { get; set; }

        public ICollection<Grad> Gradovi { get; set; }
        public ICollection<Osoba> Osobe { get; set; }



    }
}
