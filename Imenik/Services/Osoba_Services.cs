using Imenik.data;
using Imenik.IServices;
using Imenik.Models;

namespace Imenik.Services
{
    public class Osoba_Services: IOsoba
    {
        private readonly ImenikDbContext _context;

        public Osoba_Services(ImenikDbContext context)
        {
            _context = context;
        }

        public List<Osoba> DohvatiSveOsobe()
        {
            return _context.Osobe.ToList();
        }

        public Osoba DohvatiOsobu(int id)
        {
            return _context.Osobe.Find(id);
        }

        public void DodajOsobu(Osoba osoba)
        {
            _context.Osobe.Add(osoba);
            _context.SaveChanges();
        }

        public void AzurirajOsobu(Osoba osoba)
        {
            _context.Osobe.Update(osoba);
            _context.SaveChanges();
        }

        public void ObrisiOsobu(int id)
        {
            var osoba = _context.Osobe.Find(id);
            _context.Osobe.Remove(osoba);
            _context.SaveChanges();
        }   


    }
}
