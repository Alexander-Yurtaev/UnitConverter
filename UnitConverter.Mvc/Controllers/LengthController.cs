using UnitConverter.Mvc.Converters;
using UnitConverter.Mvc.Models;
using UnitConverter.Mvc.Models.Enums;

namespace UnitConverter.Mvc.Controllers
{
    public class LengthController : BaseConverterController
    {
        public LengthController(IConverterFactory converterFactory, ILogger<HomeController> logger) : base(converterFactory, logger)
        {
            
        }

        protected override ConverterType ConverterType => ConverterType.Length;

        protected override List<UnitItem> GetUnitItems()
        {
            var items = new List<UnitItem>
            {
                new UnitItem(Id: (int)Units.Millimeter, Name: "Миллиметр(mm)"),
                new UnitItem(Id: (int)Units.Centimeter, Name: "Сантиметр(cm)"),
                new UnitItem(Id: (int)Units.Meter, Name: "Метр(m)"),
                new UnitItem(Id: (int)Units.Kilometer, Name: "Километр(km)"),
                new UnitItem(Id: (int)Units.Inch, Name: "Дюйм(inch)"),
                new UnitItem(Id: (int)Units.Foot, Name: "Фут(foot)"),
                new UnitItem(Id: (int)Units.Yard, Name: "Ярд(yard)"),
                new UnitItem(Id: (int)Units.Mile, Name: "Миля(mile)"),
            };
            return items;
        }
    }
}
