
using Imenik.data;
using Imenik.IServices;
using Imenik.Models;

public class Grad_Service : IGrad
{
    private readonly ImenikDbContext _dbContext;

    public Grad_Service(ImenikDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Grad> DohvatiGradoveZaDrzavu(int drzavaId)
    {
        return _dbContext.Gradovi.Where(g => g.DrzavaId == drzavaId).ToList();
    }
}