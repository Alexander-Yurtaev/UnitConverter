using UnitConverter.Mvc.Converters;
using UnitConverter.Mvc.Models;
using UnitConverter.Mvc.Models.Enums;

namespace UnitConverter.Mvc.Controllers
{
    public class WeightController : BaseConverterController
    {
        public WeightController(IConverterFactory converterFactory, ILogger<HomeController> logger) : base(converterFactory, logger)
        {
        }

        protected override ConverterType ConverterType => ConverterType.Weight;

        protected override List<UnitItem> GetUnitItems()
        {
            var items = new List<UnitItem>
            {
                new UnitItem(Id: (int)Units.Milligrams, Name: "Миллиграмм (mg)"),
                new UnitItem(Id: (int)Units.Gram, Name: "Грамм (g)"),
                new UnitItem(Id: (int)Units.Kilogram, Name: "Килограмм (kg)"),
                new UnitItem(Id: (int)Units.Ounce, Name: "Унция (ounce)"),
                new UnitItem(Id: (int)Units.Pound, Name: "Фунт (pound)"),
            };
            return items;
        }
    }
}
