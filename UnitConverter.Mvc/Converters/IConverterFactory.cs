using UnitConverter.Mvc.Models.Enums;

namespace UnitConverter.Mvc.Converters;

public interface IConverterFactory
{
    IConverter GetConverter(ConverterType converterType);
}