using Imenik.IServices;
using Microsoft.AspNetCore.Mvc;

public class DrzavaController : Controller
{
    private readonly IDrzava _drzavaService;

    public DrzavaController(IDrzava drzavaService)
    {
        _drzavaService = drzavaService;
    }

    public IActionResult SveDrzave()
    {
        var drzave = _drzavaService.DohvatiSveDrzave();
        return View(drzave);
    }
}