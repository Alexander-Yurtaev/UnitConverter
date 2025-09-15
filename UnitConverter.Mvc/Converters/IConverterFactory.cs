using UnitConverter.Mvc.Models;
using UnitConverter.Mvc.Models.Enums;

namespace UnitConverter.Mvc.Utils;

public interface IConverterFactory
{
    IConverter GetConverter(ConverterType converterType);
}