using UnitConverter.Mvc.Models;
using UnitConverter.Mvc.Models.Enums;

namespace UnitConverter.Mvc.Utils;

public class LengthConverter : ILengthConverter
{
    public ConverterType ConverterType => ConverterType.Length;

    public ResultModel Convert(LengthUnit unitFrom, LengthUnit unitTo, decimal value)
    {
        switch (unitFrom)
        {
            case LengthUnit.Millimeter:
                return MillimeterTo(unitTo, value);
            case LengthUnit.Centimeter:
                return CentimeterTo(unitTo, value);
            case LengthUnit.Meter:
                return MeterTo(unitTo, value);
            case LengthUnit.Kilometer:
                return KilometerTo(unitTo, value);
            case LengthUnit.Inch:
                return InchTo(unitTo, value);
            case LengthUnit.Foot:
                return FootTo(unitTo, value);
            case LengthUnit.Yard:
                return YardTo(unitTo, value);
            case LengthUnit.Mile:
                return MileTo(unitTo, value);
            default:
                throw new ArgumentOutOfRangeException(nameof(unitFrom), unitFrom, null);
        }
    }

    private ResultModel MillimeterTo(LengthUnit unitTo, decimal value)
    {
        ResultModel result;
        switch (unitTo)
        {
            case LengthUnit.Millimeter:
                result = new ResultModel{ValueTo = value};
                break;
            case LengthUnit.Centimeter:
                result = new ResultModel { ValueTo = value / 10m };
                break;
            case LengthUnit.Meter:
                result = new ResultModel { ValueTo = value / 10m / 100m };
                break;
            case LengthUnit.Kilometer:
                result = new ResultModel { ValueTo = value / 10m / 100m / 1000m };
                break;
            case LengthUnit.Inch:
                result = new ResultModel { ValueTo = value / 10m / 2.54m };
                break;
            case LengthUnit.Foot:
                result = new ResultModel { ValueTo = value / 10m / 2.54m / 12m };
                break;
            case LengthUnit.Yard:
                result = new ResultModel { ValueTo = value / 10m / 2.54m / 12m / 3m };
                break;
            case LengthUnit.Mile:
                result = new ResultModel { ValueTo = value / 10m / 2.54m / 12m / 3m / 1760m };
                break;
            default:
                return new ResultModel{ Message = $"Error! Unknown UnitTo = {unitTo}" };
        }

        result.Message = unitTo.ToString();
        return result;
    }

    private ResultModel CentimeterTo(LengthUnit unitTo, decimal value)
    {
        ResultModel result;
        switch (unitTo)
        {
            case LengthUnit.Millimeter:
                result = new ResultModel { ValueTo = value * 10m };
                break;
            case LengthUnit.Centimeter:
                result = new ResultModel { ValueTo = value };
                break;
            case LengthUnit.Meter:
                result = new ResultModel { ValueTo = value / 100m };
                break;
            case LengthUnit.Kilometer:
                result = new ResultModel { ValueTo = value / 100m / 1000m };
                break;
            case LengthUnit.Inch:
                result = new ResultModel { ValueTo = value / 2.54m };
                break;
            case LengthUnit.Foot:
                result = new ResultModel { ValueTo = value / 2.54m / 12m };
                break;
            case LengthUnit.Yard:
                result = new ResultModel { ValueTo = value / 2.54m / 12m / 3m };
                break;
            case LengthUnit.Mile:
                result = new ResultModel { ValueTo = value / 2.54m / 12m / 3m / 1760m };
                break;
            default:
                return new ResultModel { Message = $"Error! Unknown UnitTo = {unitTo}" };
        }

        result.Message = unitTo.ToString();
        return result;
    }

    private ResultModel MeterTo(LengthUnit unitTo, decimal value)
    {
        ResultModel result;
        switch (unitTo)
        {
            case LengthUnit.Millimeter:
                result = new ResultModel { ValueTo = value * 10m * 100m };
                break;
            case LengthUnit.Centimeter:
                result = new ResultModel { ValueTo = value * 100m };
                break;
            case LengthUnit.Meter:
                result = new ResultModel { ValueTo = value };
                break;
            case LengthUnit.Kilometer:
                result = new ResultModel { ValueTo = value / 1000m };
                break;
            case LengthUnit.Inch:
                result = new ResultModel { ValueTo = value * 100m / 2.54m };
                break;
            case LengthUnit.Foot:
                result = new ResultModel { ValueTo = value * 100m / 2.54m / 12m };
                break;
            case LengthUnit.Yard:
                result = new ResultModel { ValueTo = value * 100m / 2.54m / 12m / 3m };
                break;
            case LengthUnit.Mile:
                result = new ResultModel { ValueTo = value * 100m / 2.54m / 12m / 3m / 1760m };
                break;
            default:
                return new ResultModel { Message = $"Error! Unknown UnitTo = {unitTo}" };
        }

        result.Message = unitTo.ToString();
        return result;
    }

    private ResultModel KilometerTo(LengthUnit unitTo, decimal value)
    {
        ResultModel result;
        switch (unitTo)
        {
            case LengthUnit.Millimeter:
                result = new ResultModel { ValueTo = value * 10m * 100m * 1000m };
                break;
            case LengthUnit.Centimeter:
                result = new ResultModel { ValueTo = value * 100m * 1000m };
                break;
            case LengthUnit.Meter:
                result = new ResultModel { ValueTo = value * 1000m };
                break;
            case LengthUnit.Kilometer:
                result = new ResultModel { ValueTo = value };
                break;
            case LengthUnit.Inch:
                result = new ResultModel { ValueTo = value * 100m * 1000m / 2.54m };
                break;
            case LengthUnit.Foot:
                result = new ResultModel { ValueTo = value * 100m * 1000m / 2.54m / 12m };
                break;
            case LengthUnit.Yard:
                result = new ResultModel { ValueTo = value * 100m * 1000m / 2.54m / 12m / 3m };
                break;
            case LengthUnit.Mile:
                result = new ResultModel { ValueTo = value * 100m * 1000m / 2.54m / 12m / 3m / 1760m };
                break;
            default:
                return new ResultModel { Message = $"Error! Unknown UnitTo = {unitTo}" };
        }

        result.Message = unitTo.ToString();
        return result;
    }

    private ResultModel InchTo(LengthUnit unitTo, decimal value)
    {
        ResultModel result;
        switch (unitTo)
        {
            case LengthUnit.Millimeter:
                result = new ResultModel { ValueTo = value * 10m * 2.54m };
                break;
            case LengthUnit.Centimeter:
                result = new ResultModel { ValueTo = value * 2.54m };
                break;
            case LengthUnit.Meter:
                result = new ResultModel { ValueTo = value * 2.54m / 100m };
                break;
            case LengthUnit.Kilometer:
                result = new ResultModel { ValueTo = value * 2.54m / 100m / 1000m };
                break;
            case LengthUnit.Inch:
                result = new ResultModel { ValueTo = value };
                break;
            case LengthUnit.Foot:
                result = new ResultModel { ValueTo = value / 12m };
                break;
            case LengthUnit.Yard:
                result = new ResultModel { ValueTo = value / 12m / 3m };
                break;
            case LengthUnit.Mile:
                result = new ResultModel { ValueTo = value / 12m / 3m / 1760m };
                break;
            default:
                return new ResultModel { Message = $"Error! Unknown UnitTo = {unitTo}" };
        }

        result.Message = unitTo.ToString();
        return result;
    }

    private ResultModel FootTo(LengthUnit unitTo, decimal value)
    {
        ResultModel result;
        switch (unitTo)
        {
            case LengthUnit.Millimeter:
                result = new ResultModel { ValueTo = value * 12m * 2.54m * 10m };
                break;
            case LengthUnit.Centimeter:
                result = new ResultModel { ValueTo = value * 12m * 2.54m };
                break;
            case LengthUnit.Meter:
                result = new ResultModel { ValueTo = value * 12m * 2.54m / 100m };
                break;
            case LengthUnit.Kilometer:
                result = new ResultModel { ValueTo = value * 12m * 2.54m / 100m / 1000m };
                break;
            case LengthUnit.Inch:
                result = new ResultModel { ValueTo = value * 12m };
                break;
            case LengthUnit.Foot:
                result = new ResultModel { ValueTo = value };
                break;
            case LengthUnit.Yard:
                result = new ResultModel { ValueTo = value / 3m };
                break;
            case LengthUnit.Mile:
                result = new ResultModel { ValueTo = value / 3m / 1760m };
                break;
            default:
                return new ResultModel { Message = $"Error! Unknown UnitTo = {unitTo}" };
        }

        result.Message = unitTo.ToString();
        return result;
    }

    private ResultModel YardTo(LengthUnit unitTo, decimal value)
    {
        ResultModel result;
        switch (unitTo)
        {
            case LengthUnit.Millimeter:
                result = new ResultModel { ValueTo = value * 3m * 12m * 2.54m * 10m };
                break;
            case LengthUnit.Centimeter:
                result = new ResultModel { ValueTo = value * 3m * 12m * 2.54m };
                break;
            case LengthUnit.Meter:
                result = new ResultModel { ValueTo = value * 3m * 12m * 2.54m / 100m };
                break;
            case LengthUnit.Kilometer:
                result = new ResultModel { ValueTo = value * 3m * 12m * 2.54m / 100m / 1000m };
                break;
            case LengthUnit.Inch:
                result = new ResultModel { ValueTo = value * 12m * 3m };
                break;
            case LengthUnit.Foot:
                result = new ResultModel { ValueTo = value * 3m };
                break;  
            case LengthUnit.Yard:
                result = new ResultModel { ValueTo = value };
                break;
            case LengthUnit.Mile:
                result = new ResultModel { ValueTo = value / 1760m };
                break;
            default:
                return new ResultModel { Message = $"Error! Unknown UnitTo = {unitTo}" };
        }

        result.Message = unitTo.ToString();
        return result;
    }

    private ResultModel MileTo(LengthUnit unitTo, decimal value)
    {
        ResultModel result;
        switch (unitTo)
        {
            case LengthUnit.Millimeter:
                result = new ResultModel { ValueTo = value * value * 1760m * 3m * 12m * 2.54m * 10m };
                break;
            case LengthUnit.Centimeter:
                result = new ResultModel { ValueTo = value * 2.54m * 12m * 3m * 1760m };
                break;
            case LengthUnit.Meter:
                result = new ResultModel { ValueTo = value * 1760m * 3m * 12m * 2.54m / 100m };
                break;
            case LengthUnit.Kilometer:
                result = new ResultModel { ValueTo = value * 1760m * 3m * 12m * 2.54m / 100m / 1000m };
                break;
            case LengthUnit.Inch:
                result = new ResultModel { ValueTo = value * 12m * 3m * 1760m };
                break;
            case LengthUnit.Foot:
                result = new ResultModel { ValueTo = value * 3m * 1760m };
                break;
            case LengthUnit.Yard:
                result = new ResultModel { ValueTo = value * 1760m };
                break;
            case LengthUnit.Mile:
                result = new ResultModel { ValueTo = value };
                break;
            default:
                return new ResultModel { Message = $"Error! Unknown UnitTo = {unitTo}" };
        }

        result.Message = unitTo.ToString();
        return result;
    }
}