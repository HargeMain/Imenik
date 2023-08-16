using Imenik.IServices;
using Microsoft.AspNetCore.Mvc;

namespace Imenik.Controllers
{
    public class GradController : Controller
    {
        private readonly IGrad _gradService;

        public GradController(IGrad gradService)
        {
            _gradService = gradService;
        }

        public IActionResult GradoviZaDrzavu(int drzavaId)
        {
            var gradovi = _gradService.DohvatiGradoveZaDrzavu(drzavaId);
            return View(gradovi);
        }
    }
}
