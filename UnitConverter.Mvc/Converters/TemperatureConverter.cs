using UnitConverter.Mvc.Models;
using UnitConverter.Mvc.Models.Enums;

namespace UnitConverter.Mvc.Converters;

public class TemperatureConverter : ITemperatureConverter
{
    public ConverterType ConverterType => ConverterType.Temperature;

    public ResultModel Convert(Units unitFrom, Units unitTo, decimal value)
    {
        return unitFrom switch
        {
            Units.Celsius => CelsiusTo(unitTo, unitFrom, value),
            Units.Kelvin => KelvinTo(unitTo, unitFrom, value),
            Units.Fahrenheit => FahrenheitTo(unitTo, unitFrom, value),
            _ => throw new ArgumentOutOfRangeException(nameof(unitFrom), unitFrom, null)
        };
    }

    private ResultModel CelsiusTo(Units unitTo, Units unitFrom, decimal value)
    {
        switch (unitTo)
        {
            case Units.Celsius:
                return new ResultModel { OriginalUnit = Units.Celsius, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value };
            case Units.Kelvin:
                return new ResultModel { OriginalUnit = Units.Celsius, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value + 273.15m };
            case Units.Fahrenheit:
                return new ResultModel {OriginalUnit = Units.Celsius, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value / (5m / 9m) + 32 };
            default:
                return new ResultModel { ErrorMessage = $"Error! Unknown UnitTo = {unitTo}" };
        }
    }

    private ResultModel KelvinTo(Units unitTo, Units unitFrom, decimal value)
    {
        switch (unitTo)
        {
            case Units.Celsius:
                return new ResultModel { OriginalUnit = Units.Kelvin, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value - 273.15m };
            case Units.Kelvin:
                return new ResultModel { OriginalUnit = Units.Kelvin, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value };
            case Units.Fahrenheit:
                return new ResultModel { OriginalUnit = Units.Kelvin, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = (value - 273.15m) / (5m / 9m) + 32 };
            default:
                return new ResultModel { ErrorMessage = $"Error! Unknown UnitTo = {unitTo}" };
        }
    }

    private ResultModel FahrenheitTo(Units unitTo, Units unitFrom, decimal value)
    {
        switch (unitTo)
        {
            case Units.Celsius:
                return new ResultModel { OriginalUnit = Units.Fahrenheit, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = (value - 32m) * (5m/9m) };
            case Units.Kelvin:
                return new ResultModel { OriginalUnit = Units.Fahrenheit, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = (value - 32m) * (5m/9m) + 273.15m };
            case Units.Fahrenheit:
                return new ResultModel { OriginalUnit = Units.Fahrenheit, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value };
            default:
                return new ResultModel { ErrorMessage = $"Error! Unknown UnitTo = {unitTo}" };
        }
    }
}