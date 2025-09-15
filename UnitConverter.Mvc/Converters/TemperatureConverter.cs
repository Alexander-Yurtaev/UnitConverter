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
        ResultModel result;
        switch (unitTo)
        {
            case Units.Celsius:
                result = new ResultModel { ValueTo = value };
                break;
            case Units.Kelvin:
                result = new ResultModel { ValueTo = value + 273.15m };
                break;
            case Units.Fahrenheit:
                result = new ResultModel { ValueTo = value / (5m/9m) + 32 };
                break;
            default:
                return new ResultModel { Message = $"Error! Unknown UnitTo = {unitTo}" };
        }

        result.Message = unitTo.ToString();
        return result;
    }

    private ResultModel KelvinTo(Units unitTo, Units unitFrom, decimal value)
    {
        ResultModel result;
        switch (unitTo)
        {
            case Units.Celsius:
                result = new ResultModel { ValueTo = value - 273.15m };
                break;
            case Units.Kelvin:
                result = new ResultModel { ValueTo = value };
                break;
            case Units.Fahrenheit:
                result = new ResultModel { ValueTo = (value - 273.15m) / (5m / 9m) + 32 };
                break;
            default:
                return new ResultModel { Message = $"Error! Unknown UnitTo = {unitTo}" };
        }

        result.Message = unitTo.ToString();
        return result;
    }

    private ResultModel FahrenheitTo(Units unitTo, Units unitFrom, decimal value)
    {
        ResultModel result;
        switch (unitTo)
        {
            case Units.Celsius:
                result = new ResultModel { ValueTo = (value - 32m) * (5m/9m) };
                break;
            case Units.Kelvin:
                result = new ResultModel { ValueTo = (value - 32m) * (5m/9m) + 273.15m };
                break;
            case Units.Fahrenheit:
                result = new ResultModel { ValueTo = value };
                break;
            default:
                return new ResultModel { Message = $"Error! Unknown UnitTo = {unitTo}" };
        }

        result.Message = unitTo.ToString();
        return result;
    }
}