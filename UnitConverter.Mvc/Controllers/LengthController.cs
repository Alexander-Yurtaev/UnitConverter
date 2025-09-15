using Microsoft.AspNetCore.Mvc;
using UnitConverter.Mvc.Models;
using UnitConverter.Mvc.Models.Enums;
using UnitConverter.Mvc.Utils;

namespace UnitConverter.Mvc.Controllers
{
    public class LengthController : BaseConverterController
    {
        private readonly IConverterFactory _converterFactory;

        public LengthController(IConverterFactory converterFactory, ILogger<HomeController> logger) : base(logger)
        {
            _converterFactory = converterFactory;
        }

        public override IActionResult Index()
        {
            var model = new FormModel
            {
                UnitItems = GetUnitItems()
            };
            return View(model);
        }

        public override IActionResult Convert(FormModel model)
        {
            var converter = _converterFactory.GetConverter(ConverterType.Length);
            var result = converter.Convert((LengthUnit)model.UnitFrom, (LengthUnit)model.UnitTo, model.ValueFrom);

            return View(result);
        }

        protected override List<UnitItem> GetUnitItems()
        {
            var items = new List<UnitItem>
            {
                new UnitItem(Id: (int)LengthUnit.Millimeter, Name: "Миллиметр(mm)"),
                new UnitItem(Id: (int)LengthUnit.Centimeter, Name: "Сантиметр(cm)"),
                new UnitItem(Id: (int)LengthUnit.Meter, Name: "Метр(m)"),
                new UnitItem(Id: (int)LengthUnit.Kilometer, Name: "Километр(km)"),
                new UnitItem(Id: (int)LengthUnit.Inch, Name: "Дюйм(inch)"),
                new UnitItem(Id: (int)LengthUnit.Foot, Name: "Фут(foot)"),
                new UnitItem(Id: (int)LengthUnit.Yard, Name: "Ярд(yard)"),
                new UnitItem(Id: (int)LengthUnit.Mile, Name: "Миля(mile)"),
            };
            return items;
        }
    }
}
