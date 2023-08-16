using System.ComponentModel.DataAnnotations;

namespace Imenik.Models
{
    public class Grad
    {
        [Key]
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int DrzavaId { get; set; }

        public Drzava Drzava { get; set; }

        public ICollection<Osoba> Osobe { get; set; }

       
    }
}
