using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UnitConverter.Mvc.Models;

namespace UnitConverter.Mvc.Controllers
{
    public abstract class BaseConverterController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        protected BaseConverterController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public abstract IActionResult Index();

        public abstract IActionResult Convert(FormModel model);

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        protected abstract List<UnitItem> GetUnitItems();
    }
}
