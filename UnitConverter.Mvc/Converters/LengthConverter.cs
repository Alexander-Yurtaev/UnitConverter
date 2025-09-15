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
        ResultModel result;
        switch (unitTo)
        {
            case Units.Millimeter:
                result = new ResultModel{ValueTo = value};
                break;
            case Units.Centimeter:
                result = new ResultModel { ValueTo = value / 10m };
                break;
            case Units.Meter:
                result = new ResultModel { ValueTo = value / 10m / 100m };
                break;
            case Units.Kilometer:
                result = new ResultModel { ValueTo = value / 10m / 100m / 1000m };
                break;
            case Units.Inch:
                result = new ResultModel { ValueTo = value / 10m / 2.54m };
                break;
            case Units.Foot:
                result = new ResultModel { ValueTo = value / 10m / 2.54m / 12m };
                break;
            case Units.Yard:
                result = new ResultModel { ValueTo = value / 10m / 2.54m / 12m / 3m };
                break;
            case Units.Mile:
                result = new ResultModel { ValueTo = value / 10m / 2.54m / 12m / 3m / 1760m };
                break;
            default:
                return new ResultModel{ Message = $"Error! Unknown UnitTo = {unitTo}" };
        }

        result.Message = unitTo.ToString();
        return result;
    }

    private ResultModel CentimeterTo(Units unitTo, decimal value)
    {
        ResultModel result;
        switch (unitTo)
        {
            case Units.Millimeter:
                result = new ResultModel { ValueTo = value * 10m };
                break;
            case Units.Centimeter:
                result = new ResultModel { ValueTo = value };
                break;
            case Units.Meter:
                result = new ResultModel { ValueTo = value / 100m };
                break;
            case Units.Kilometer:
                result = new ResultModel { ValueTo = value / 100m / 1000m };
                break;
            case Units.Inch:
                result = new ResultModel { ValueTo = value / 2.54m };
                break;
            case Units.Foot:
                result = new ResultModel { ValueTo = value / 2.54m / 12m };
                break;
            case Units.Yard:
                result = new ResultModel { ValueTo = value / 2.54m / 12m / 3m };
                break;
            case Units.Mile:
                result = new ResultModel { ValueTo = value / 2.54m / 12m / 3m / 1760m };
                break;
            default:
                return new ResultModel { Message = $"Error! Unknown UnitTo = {unitTo}" };
        }

        result.Message = unitTo.ToString();
        return result;
    }

    private ResultModel MeterTo(Units unitTo, decimal value)
    {
        ResultModel result;
        switch (unitTo)
        {
            case Units.Millimeter:
                result = new ResultModel { ValueTo = value * 10m * 100m };
                break;
            case Units.Centimeter:
                result = new ResultModel { ValueTo = value * 100m };
                break;
            case Units.Meter:
                result = new ResultModel { ValueTo = value };
                break;
            case Units.Kilometer:
                result = new ResultModel { ValueTo = value / 1000m };
                break;
            case Units.Inch:
                result = new ResultModel { ValueTo = value * 100m / 2.54m };
                break;
            case Units.Foot:
                result = new ResultModel { ValueTo = value * 100m / 2.54m / 12m };
                break;
            case Units.Yard:
                result = new ResultModel { ValueTo = value * 100m / 2.54m / 12m / 3m };
                break;
            case Units.Mile:
                result = new ResultModel { ValueTo = value * 100m / 2.54m / 12m / 3m / 1760m };
                break;
            default:
                return new ResultModel { Message = $"Error! Unknown UnitTo = {unitTo}" };
        }

        result.Message = unitTo.ToString();
        return result;
    }

    private ResultModel KilometerTo(Units unitTo, decimal value)
    {
        ResultModel result;
        switch (unitTo)
        {
            case Units.Millimeter:
                result = new ResultModel { ValueTo = value * 10m * 100m * 1000m };
                break;
            case Units.Centimeter:
                result = new ResultModel { ValueTo = value * 100m * 1000m };
                break;
            case Units.Meter:
                result = new ResultModel { ValueTo = value * 1000m };
                break;
            case Units.Kilometer:
                result = new ResultModel { ValueTo = value };
                break;
            case Units.Inch:
                result = new ResultModel { ValueTo = value * 100m * 1000m / 2.54m };
                break;
            case Units.Foot:
                result = new ResultModel { ValueTo = value * 100m * 1000m / 2.54m / 12m };
                break;
            case Units.Yard:
                result = new ResultModel { ValueTo = value * 100m * 1000m / 2.54m / 12m / 3m };
                break;
            case Units.Mile:
                result = new ResultModel { ValueTo = value * 100m * 1000m / 2.54m / 12m / 3m / 1760m };
                break;
            default:
                return new ResultModel { Message = $"Error! Unknown UnitTo = {unitTo}" };
        }

        result.Message = unitTo.ToString();
        return result;
    }

    private ResultModel InchTo(Units unitTo, decimal value)
    {
        ResultModel result;
        switch (unitTo)
        {
            case Units.Millimeter:
                result = new ResultModel { ValueTo = value * 10m * 2.54m };
                break;
            case Units.Centimeter:
                result = new ResultModel { ValueTo = value * 2.54m };
                break;
            case Units.Meter:
                result = new ResultModel { ValueTo = value * 2.54m / 100m };
                break;
            case Units.Kilometer:
                result = new ResultModel { ValueTo = value * 2.54m / 100m / 1000m };
                break;
            case Units.Inch:
                result = new ResultModel { ValueTo = value };
                break;
            case Units.Foot:
                result = new ResultModel { ValueTo = value / 12m };
                break;
            case Units.Yard:
                result = new ResultModel { ValueTo = value / 12m / 3m };
                break;
            case Units.Mile:
                result = new ResultModel { ValueTo = value / 12m / 3m / 1760m };
                break;
            default:
                return new ResultModel { Message = $"Error! Unknown UnitTo = {unitTo}" };
        }

        result.Message = unitTo.ToString();
        return result;
    }

    private ResultModel FootTo(Units unitTo, decimal value)
    {
        ResultModel result;
        switch (unitTo)
        {
            case Units.Millimeter:
                result = new ResultModel { ValueTo = value * 12m * 2.54m * 10m };
                break;
            case Units.Centimeter:
                result = new ResultModel { ValueTo = value * 12m * 2.54m };
                break;
            case Units.Meter:
                result = new ResultModel { ValueTo = value * 12m * 2.54m / 100m };
                break;
            case Units.Kilometer:
                result = new ResultModel { ValueTo = value * 12m * 2.54m / 100m / 1000m };
                break;
            case Units.Inch:
                result = new ResultModel { ValueTo = value * 12m };
                break;
            case Units.Foot:
                result = new ResultModel { ValueTo = value };
                break;
            case Units.Yard:
                result = new ResultModel { ValueTo = value / 3m };
                break;
            case Units.Mile:
                result = new ResultModel { ValueTo = value / 3m / 1760m };
                break;
            default:
                return new ResultModel { Message = $"Error! Unknown UnitTo = {unitTo}" };
        }

        result.Message = unitTo.ToString();
        return result;
    }

    private ResultModel YardTo(Units unitTo, decimal value)
    {
        ResultModel result;
        switch (unitTo)
        {
            case Units.Millimeter:
                result = new ResultModel { ValueTo = value * 3m * 12m * 2.54m * 10m };
                break;
            case Units.Centimeter:
                result = new ResultModel { ValueTo = value * 3m * 12m * 2.54m };
                break;
            case Units.Meter:
                result = new ResultModel { ValueTo = value * 3m * 12m * 2.54m / 100m };
                break;
            case Units.Kilometer:
                result = new ResultModel { ValueTo = value * 3m * 12m * 2.54m / 100m / 1000m };
                break;
            case Units.Inch:
                result = new ResultModel { ValueTo = value * 12m * 3m };
                break;
            case Units.Foot:
                result = new ResultModel { ValueTo = value * 3m };
                break;  
            case Units.Yard:
                result = new ResultModel { ValueTo = value };
                break;
            case Units.Mile:
                result = new ResultModel { ValueTo = value / 1760m };
                break;
            default:
                return new ResultModel { Message = $"Error! Unknown UnitTo = {unitTo}" };
        }

        result.Message = unitTo.ToString();
        return result;
    }

    private ResultModel MileTo(Units unitTo, decimal value)
    {
        ResultModel result;
        switch (unitTo)
        {
            case Units.Millimeter:
                result = new ResultModel { ValueTo = value * value * 1760m * 3m * 12m * 2.54m * 10m };
                break;
            case Units.Centimeter:
                result = new ResultModel { ValueTo = value * 2.54m * 12m * 3m * 1760m };
                break;
            case Units.Meter:
                result = new ResultModel { ValueTo = value * 1760m * 3m * 12m * 2.54m / 100m };
                break;
            case Units.Kilometer:
                result = new ResultModel { ValueTo = value * 1760m * 3m * 12m * 2.54m / 100m / 1000m };
                break;
            case Units.Inch:
                result = new ResultModel { ValueTo = value * 12m * 3m * 1760m };
                break;
            case Units.Foot:
                result = new ResultModel { ValueTo = value * 3m * 1760m };
                break;
            case Units.Yard:
                result = new ResultModel { ValueTo = value * 1760m };
                break;
            case Units.Mile:
                result = new ResultModel { ValueTo = value };
                break;
            default:
                return new ResultModel { Message = $"Error! Unknown UnitTo = {unitTo}" };
        }

        result.Message = unitTo.ToString();
        return result;
    }
}