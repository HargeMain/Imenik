using Imenik.Models;

namespace Imenik.IServices
{
    public interface IOsoba
    {
        List<Osoba> DohvatiSveOsobe();
        Osoba DohvatiOsobu(int id);
        void DodajOsobu(Osoba osoba);
        void AzurirajOsobu(Osoba osoba);
        void ObrisiOsobu(int id);


    }
}
