using UnitConverter.Mvc.Models;
using UnitConverter.Mvc.Models.Enums;

namespace UnitConverter.Mvc.Utils;

public interface IConverter
{
    ConverterType ConverterType { get; }
    ResultModel Convert(LengthUnit unitFrom, LengthUnit unitTo, decimal value);
}