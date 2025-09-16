using UnitConverter.Mvc.Models;
using UnitConverter.Mvc.Models.Enums;

namespace UnitConverter.Mvc.Converters;

public class LengthConverter : ILengthConverter
{
    public ConverterType ConverterType => ConverterType.Length;

    public ResultModel Convert(Units unitFrom, Units unitTo, decimal value)
    {
        return unitFrom switch
        {
            Units.Millimeter => MillimeterTo(unitTo, value),
            Units.Centimeter => CentimeterTo(unitTo, value),
            Units.Meter => MeterTo(unitTo, value),
            Units.Kilometer => KilometerTo(unitTo, value),
            Units.Inch => InchTo(unitTo, value),
            Units.Foot => FootTo(unitTo, value),
            Units.Yard => YardTo(unitTo, value),
            Units.Mile => MileTo(unitTo, value),
            _ => throw new ArgumentOutOfRangeException(nameof(unitFrom), unitFrom, null)
        };
    }

    private ResultModel MillimeterTo(Units unitTo, decimal value)
    {
        switch (unitTo)
        {
            case Units.Millimeter:
                return new ResultModel { OriginalUnit = Units.Millimeter, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value };
            case Units.Centimeter:
                return new ResultModel { OriginalUnit = Units.Millimeter, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value / 10m };
            case Units.Meter:
                return new ResultModel { OriginalUnit = Units.Millimeter, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value / 10m / 100m };
            case Units.Kilometer:
                return new ResultModel { OriginalUnit = Units.Millimeter, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value / 10m / 100m / 1000m };
            case Units.Inch:
                return new ResultModel { OriginalUnit = Units.Millimeter, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value / 10m / 2.54m };
            case Units.Foot:
                return new ResultModel { OriginalUnit = Units.Millimeter, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value / 10m / 2.54m / 12m };
            case Units.Yard:
                return new ResultModel { OriginalUnit = Units.Millimeter, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value / 10m / 2.54m / 12m / 3m };
            case Units.Mile:
                return new ResultModel { OriginalUnit = Units.Millimeter, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value / 10m / 2.54m / 12m / 3m / 1760m };
            default:
                return new ResultModel { ErrorMessage = $"Error! Unknown UnitTo = {unitTo}" };
        }
    }

    private ResultModel CentimeterTo(Units unitTo, decimal value)
    {
        switch (unitTo)
        {
            case Units.Millimeter:
                return new ResultModel { OriginalUnit = Units.Centimeter, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 10m };
            case Units.Centimeter:
                return new ResultModel { OriginalUnit = Units.Centimeter, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value };
            case Units.Meter:
                return new ResultModel { OriginalUnit = Units.Centimeter, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value / 100m };
            case Units.Kilometer:
                return new ResultModel { OriginalUnit = Units.Centimeter, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value / 100m / 1000m };
            case Units.Inch:
                return new ResultModel { OriginalUnit = Units.Centimeter, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value / 2.54m };
            case Units.Foot:
                return new ResultModel { OriginalUnit = Units.Centimeter, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value / 2.54m / 12m };
            case Units.Yard:
                return new ResultModel { OriginalUnit = Units.Centimeter, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value / 2.54m / 12m / 3m };
            case Units.Mile:
                return new ResultModel { OriginalUnit = Units.Centimeter, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value / 2.54m / 12m / 3m / 1760m };
            default:
                return new ResultModel { ErrorMessage = $"Error! Unknown UnitTo = {unitTo}" };
        }
    }

    private ResultModel MeterTo(Units unitTo, decimal value)
    {
        switch (unitTo)
        {
            case Units.Millimeter:
                return new ResultModel { OriginalUnit = Units.Meter, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 10m * 100m };
            case Units.Centimeter:
                return new ResultModel { OriginalUnit = Units.Meter, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 100m };
            case Units.Meter:
                return new ResultModel { OriginalUnit = Units.Meter, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value };
            case Units.Kilometer:
                return new ResultModel { OriginalUnit = Units.Meter, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value / 1000m };
            case Units.Inch:
                return new ResultModel { OriginalUnit = Units.Meter, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 100m / 2.54m };
            case Units.Foot:
                return new ResultModel { OriginalUnit = Units.Meter, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 100m / 2.54m / 12m };
            case Units.Yard:
                return new ResultModel { OriginalUnit = Units.Meter, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 100m / 2.54m / 12m / 3m };
            case Units.Mile:
                return new ResultModel { OriginalUnit = Units.Meter, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 100m / 2.54m / 12m / 3m / 1760m };
            default:
                return new ResultModel { ErrorMessage = $"Error! Unknown UnitTo = {unitTo}" };
        }
    }

    private ResultModel KilometerTo(Units unitTo, decimal value)
    {
        switch (unitTo)
        {
            case Units.Millimeter:
                return new ResultModel { OriginalUnit = Units.Kilometer, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 10m * 100m * 1000m };
            case Units.Centimeter:
                return new ResultModel { OriginalUnit = Units.Kilometer, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 100m * 1000m };
            case Units.Meter:
                return new ResultModel { OriginalUnit = Units.Kilometer, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 1000m };
            case Units.Kilometer:
                return new ResultModel { OriginalUnit = Units.Kilometer, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value };
            case Units.Inch:
                return new ResultModel { OriginalUnit = Units.Kilometer, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 100m * 1000m / 2.54m };
            case Units.Foot:
                return new ResultModel { OriginalUnit = Units.Kilometer, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 100m * 1000m / 2.54m / 12m };
            case Units.Yard:
                return new ResultModel { OriginalUnit = Units.Kilometer, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 100m * 1000m / 2.54m / 12m / 3m };
            case Units.Mile:
                return new ResultModel { OriginalUnit = Units.Kilometer, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 100m * 1000m / 2.54m / 12m / 3m / 1760m };
            default:
                return new ResultModel { ErrorMessage = $"Error! Unknown UnitTo = {unitTo}" };
        }
    }

    private ResultModel InchTo(Units unitTo, decimal value)
    {
        switch (unitTo)
        {
            case Units.Millimeter:
                return new ResultModel { OriginalUnit = Units.Inch, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 10m * 2.54m };
            case Units.Centimeter:
                return new ResultModel { OriginalUnit = Units.Inch, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 2.54m };
            case Units.Meter:
                return new ResultModel { OriginalUnit = Units.Inch, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 2.54m / 100m };
            case Units.Kilometer:
                return new ResultModel { OriginalUnit = Units.Inch, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 2.54m / 100m / 1000m };
            case Units.Inch:
                return new ResultModel { OriginalUnit = Units.Inch, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value };
            case Units.Foot:
                return new ResultModel { OriginalUnit = Units.Inch, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value / 12m };
            case Units.Yard:
                return new ResultModel { OriginalUnit = Units.Inch, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value / 12m / 3m };
            case Units.Mile:
                return new ResultModel { OriginalUnit = Units.Inch, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value / 12m / 3m / 1760m };
            default:
                return new ResultModel { ErrorMessage = $"Error! Unknown UnitTo = {unitTo}" };
        }
    }

    private ResultModel FootTo(Units unitTo, decimal value)
    {
        switch (unitTo)
        {
            case Units.Millimeter:
                return new ResultModel { OriginalUnit = Units.Foot, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 12m * 2.54m * 10m };
            case Units.Centimeter:
                return new ResultModel { OriginalUnit = Units.Foot, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 12m * 2.54m };
            case Units.Meter:
                return new ResultModel { OriginalUnit = Units.Foot, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 12m * 2.54m / 100m };
            case Units.Kilometer:
                return new ResultModel { OriginalUnit = Units.Foot, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 12m * 2.54m / 100m / 1000m };
            case Units.Inch:
                return new ResultModel { OriginalUnit = Units.Foot, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 12m };
            case Units.Foot:
                return new ResultModel { OriginalUnit = Units.Foot, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value };
            case Units.Yard:
                return new ResultModel { OriginalUnit = Units.Foot, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value / 3m };
            case Units.Mile:
                return new ResultModel { OriginalUnit = Units.Foot, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value / 3m / 1760m };
            default:
                return new ResultModel { ErrorMessage = $"Error! Unknown UnitTo = {unitTo}" };
        }
    }

    private ResultModel YardTo(Units unitTo, decimal value)
    {
        switch (unitTo)
        {
            case Units.Millimeter:
                return new ResultModel { OriginalUnit = Units.Yard, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 3m * 12m * 2.54m * 10m };
            case Units.Centimeter:
                return new ResultModel { OriginalUnit = Units.Yard, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 3m * 12m * 2.54m };
            case Units.Meter:
                return new ResultModel { OriginalUnit = Units.Yard, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 3m * 12m * 2.54m / 100m };
            case Units.Kilometer:
                return new ResultModel { OriginalUnit = Units.Yard, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 3m * 12m * 2.54m / 100m / 1000m };
            case Units.Inch:
                return new ResultModel { OriginalUnit = Units.Yard, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 12m * 3m };
            case Units.Foot:
                return new ResultModel { OriginalUnit = Units.Yard, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 3m };
            case Units.Yard:
                return new ResultModel { OriginalUnit = Units.Yard, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value };
            case Units.Mile:
                return new ResultModel { OriginalUnit = Units.Yard, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value / 1760m };
            default:
                return new ResultModel { ErrorMessage = $"Error! Unknown UnitTo = {unitTo}" };
        }
    }

    private ResultModel MileTo(Units unitTo, decimal value)
    {
        switch (unitTo)
        {
            case Units.Millimeter:
                return new ResultModel { OriginalUnit = Units.Mile, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * value * 1760m * 3m * 12m * 2.54m * 10m };
            case Units.Centimeter:
                return new ResultModel { OriginalUnit = Units.Mile, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 2.54m * 12m * 3m * 1760m };
            case Units.Meter:
                return new ResultModel { OriginalUnit = Units.Mile, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 1760m * 3m * 12m * 2.54m / 100m };
            case Units.Kilometer:
                return new ResultModel { OriginalUnit = Units.Mile, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 1760m * 3m * 12m * 2.54m / 100m / 1000m };
            case Units.Inch:
                return new ResultModel { OriginalUnit = Units.Mile, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 12m * 3m * 1760m };
            case Units.Foot:
                return new ResultModel { OriginalUnit = Units.Mile, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 3m * 1760m };
            case Units.Yard:
                return new ResultModel { OriginalUnit = Units.Mile, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 1760m };
            case Units.Mile:
                return new ResultModel { OriginalUnit = Units.Mile, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value };
            default:
                return new ResultModel { ErrorMessage = $"Error! Unknown UnitTo = {unitTo}" };
        }
    }
}