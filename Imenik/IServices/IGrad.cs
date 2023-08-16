using Imenik.Models;

namespace Imenik.IServices
{
    public interface IGrad
    {
        List<Grad> DohvatiGradoveZaDrzavu(int drzavaId);
    }
}
