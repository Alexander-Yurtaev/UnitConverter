using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UnitConverter.Mvc.Converters;
using UnitConverter.Mvc.Models;
using UnitConverter.Mvc.Models.Enums;

namespace UnitConverter.Mvc.Controllers
{
    public abstract class BaseConverterController : Controller
    {
        protected readonly IConverterFactory ConverterFactory;
        protected readonly ILogger<HomeController> Logger;
        protected abstract ConverterType ConverterType { get; }

        protected BaseConverterController(IConverterFactory converterFactory, ILogger<HomeController> logger)
        {
            ConverterFactory = converterFactory;
            Logger = logger;
        }

        public virtual IActionResult Index()
        {
            var model = new FormModel
            {
                UnitItems = GetUnitItems()
            };
            return View(model);
        }

        public virtual IActionResult Convert(FormModel model)
        {
            var converter = ConverterFactory.GetConverter(this.ConverterType);
            var result = converter.Convert((Units)model.UnitFrom, (Units)model.UnitTo, model.ValueFrom);

            return View(result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        protected abstract List<UnitItem> GetUnitItems();
    }
}
