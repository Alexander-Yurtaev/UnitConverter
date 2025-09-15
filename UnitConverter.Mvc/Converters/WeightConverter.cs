using UnitConverter.Mvc.Models;
using UnitConverter.Mvc.Models.Enums;

namespace UnitConverter.Mvc.Converters;

public class WeightConverter : IWeightConverter
{
    public ConverterType ConverterType => ConverterType.Weight;

    public ResultModel Convert(Units unitFrom, Units unitTo, decimal value)
    {
        return unitFrom switch
        {
            Units.Milligrams => MilligramsTo(unitTo, unitFrom, value),
            Units.Gram => GramTo(unitTo, unitFrom, value),
            Units.Kilogram => KilogramTo(unitTo, unitFrom, value),
            Units.Ounce => OunceTo(unitTo, unitFrom, value),
            Units.Pound => PoundTo(unitTo, unitFrom, value),
            _ => throw new ArgumentOutOfRangeException(nameof(unitFrom), unitFrom, null)
        };
    }

    private ResultModel MilligramsTo(Units unitTo, Units unitFrom, decimal value)
    {
        ResultModel result;
        switch (unitTo)
        {
            case Units.Milligrams:
                result = new ResultModel { ValueTo = value };
                break;
            case Units.Gram:
                result = new ResultModel { ValueTo = value / 1000m };
                break;
            case Units.Kilogram:
                result = new ResultModel { ValueTo = value / 1000m / 1000m };
                break;
            case Units.Ounce:
                result = new ResultModel { ValueTo = value / 16m / 2.20462m / 1000m / 1000m };
                break;
            case Units.Pound:
                result = new ResultModel { ValueTo = value / 2.20462m / 1000m / 1000m };
                break;
            default:
                return new ResultModel { Message = $"Error! Unknown UnitTo = {unitTo}" };
        }

        result.Message = unitTo.ToString();
        return result;
    }

    private ResultModel GramTo(Units unitTo, Units unitFrom, decimal value)
    {
        ResultModel result;
        switch (unitTo)
        {
            case Units.Milligrams:
                result = new ResultModel { ValueTo = value * 1000m };
                break;
            case Units.Gram:
                result = new ResultModel { ValueTo = value };
                break;
            case Units.Kilogram:
                result = new ResultModel { ValueTo = value / 1000m };
                break;
            case Units.Ounce:
                result = new ResultModel { ValueTo = value / 28.3495m };
                break;
            case Units.Pound:
                result = new ResultModel { ValueTo = value / 2.20462m / 1000m };
                break;
            default:
                return new ResultModel { Message = $"Error! Unknown UnitTo = {unitTo}" };
        }

        result.Message = unitTo.ToString();
        return result;
    }

    private ResultModel KilogramTo(Units unitTo, Units unitFrom, decimal value)
    {
        ResultModel result;
        switch (unitTo)
        {
            case Units.Milligrams:
                result = new ResultModel { ValueTo = value * 1000m * 1000m };
                break;
            case Units.Gram:
                result = new ResultModel { ValueTo = value * 1000m };
                break;
            case Units.Kilogram:
                result = new ResultModel { ValueTo = value };
                break;
            case Units.Ounce:
                result = new ResultModel { ValueTo = value / 16m / 2.20462m };
                break;
            case Units.Pound:
                result = new ResultModel { ValueTo = value * 2.20462m };
                break;
            default:
                return new ResultModel { Message = $"Error! Unknown UnitTo = {unitTo}" };
        }

        result.Message = unitTo.ToString();
        return result;
    }

    private ResultModel OunceTo(Units unitTo, Units unitFrom, decimal value)
    {
        ResultModel result;
        switch (unitTo)
        {
            case Units.Milligrams:
                result = new ResultModel { ValueTo = value / 16m / 2.20462m * 1000m * 1000m };
                break;
            case Units.Gram:
                result = new ResultModel { ValueTo = value * 28.3495m };
                break;
            case Units.Kilogram:
                result = new ResultModel { ValueTo = value / 16m / 2.20462m };
                break;
            case Units.Ounce:
                result = new ResultModel { ValueTo = value };
                break;
            case Units.Pound:
                result = new ResultModel { ValueTo = value / 16m };
                break;
            default:
                return new ResultModel { Message = $"Error! Unknown UnitTo = {unitTo}" };
        }

        result.Message = unitTo.ToString();
        return result;
    }

    private ResultModel PoundTo(Units unitTo, Units unitFrom, decimal value)
    {
        ResultModel result;
        switch (unitTo)
        {
            case Units.Milligrams:
                result = new ResultModel { ValueTo = value * 16m / 2.20462m * 1000m * 1000m };
                break;
            case Units.Gram:
                result = new ResultModel { ValueTo = value * 16m / 2.20462m * 1000m };
                break;
            case Units.Kilogram:
                result = new ResultModel { ValueTo = value / 2.20462m };
                break;
            case Units.Ounce:
                result = new ResultModel { ValueTo = value * 16m };
                break;
            case Units.Pound:
                result = new ResultModel { ValueTo = value };
                break;
            default:
                return new ResultModel { Message = $"Error! Unknown UnitTo = {unitTo}" };
        }

        result.Message = unitTo.ToString();
        return result;
    }
}