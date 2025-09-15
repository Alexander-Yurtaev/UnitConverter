using UnitConverter.Mvc.Converters;
using UnitConverter.Mvc.Models;
using UnitConverter.Mvc.Models.Enums;

namespace UnitConverter.Mvc.Controllers
{
    public class TemperatureController : BaseConverterController
    {
        public TemperatureController(IConverterFactory converterFactory, ILogger<HomeController> logger) : base(converterFactory, logger)
        {
        }

        protected override ConverterType ConverterType => ConverterType.Temperature;

        protected override List<UnitItem> GetUnitItems()
        {
            var items = new List<UnitItem>
            {
                new UnitItem(Id: (int)Units.Celsius, Name: "Цельсий (°C)"),
                new UnitItem(Id: (int)Units.Kelvin, Name: "Кельфин (K)"),
                new UnitItem(Id: (int)Units.Fahrenheit, Name: "Фаренгейт (F)")
            };
            return items;
        }
    }
}
