using UnitConverter.Mvc.Models;
using UnitConverter.Mvc.Models.Enums;

namespace UnitConverter.Mvc.Converters;

public interface IConverter
{
    ConverterType ConverterType { get; }
    string ControllerName { get; }
    ResultModel Convert(Units unitFrom, Units unitTo, decimal value);
}