using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Imenik.Models;
using Imenik.data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Imenik.Controllers
{
    public class OsobaController : Controller
    {
        private readonly ImenikDbContext _context;

        public OsobaController(ImenikDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var osobe = _context.Osobe.Include(o => o.Grad).Include(o => o.Drzava);
            return View(osobe);
        }

        public IActionResult Izmijeni(int id)
        {
            var osoba = _context.Osobe.Find(id);
            if (osoba == null)
            {
                return NotFound();
            }

            ViewData["Gradovi"] = new SelectList(_context.Gradovi, "Id", "Naziv", osoba.GradId);
            ViewData["Drzave"] = new SelectList(_context.Drzave, "Id", "Naziv", osoba.DrzavaId);

            return View(osoba);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Izmijeni(int id, [Bind("Id,Ime,Prezime,BrojTelefona,Pol,Email,GradId,DrzavaId,DatumRodjenja,Starost")] Osoba osoba)
        {
            if (id != osoba.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(osoba);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OsobaExists(osoba.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            ViewData["Gradovi"] = new SelectList(_context.Gradovi, "Id", "Naziv", osoba.GradId);
            ViewData["Drzave"] = new SelectList(_context.Drzave, "Id", "Naziv", osoba.DrzavaId);

            return View(osoba);
        }

        public IActionResult Dodaj()
        {
            ViewData["Gradovi"] = new SelectList(_context.Gradovi, "Id", "Naziv");
            ViewData["Drzave"] = new SelectList(_context.Drzave, "Id", "Naziv");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Dodaj([Bind("Ime,Prezime,BrojTelefona,Pol,Email,GradId,DrzavaId,DatumRodjenja,Starost")] Osoba osoba)
        {
            if (ModelState.IsValid)
            {
                _context.Add(osoba);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            ViewData["Gradovi"] = new SelectList(_context.Gradovi, "Id", "Naziv", osoba.GradId);
            ViewData["Drzave"] = new SelectList(_context.Drzave, "Id", "Naziv", osoba.DrzavaId);

            return View(osoba);
        }

        [HttpPost, ActionName("Obrisi")]
        [ValidateAntiForgeryToken]
        public IActionResult ObrisiPotvrda(int id)
        {
            var osoba = _context.Osobe.Find(id);
            if (osoba == null)
            {
                return NotFound();
            }

            _context.Osobe.Remove(osoba);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool OsobaExists(int id)
        {
            return _context.Osobe.Any(e => e.Id == id);
        }
    }
}
