
using Imenik.data;
using Imenik.IServices;
using Imenik.Models;

public class DrzavaService : IDrzava
{
    private readonly ImenikDbContext _dbContext;

    public DrzavaService(ImenikDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Drzava> DohvatiSveDrzave()
    {
        return _dbContext.Drzave.ToList();
    }
}