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
        switch (unitTo)
        {
            case Units.Milligrams:
                return new ResultModel {OriginalUnit = Units.Milligrams, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value };
            case Units.Gram:
                return new ResultModel { OriginalUnit = Units.Milligrams, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value / 1000m };
            case Units.Kilogram:
                return new ResultModel { OriginalUnit = Units.Milligrams, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value / 1000m / 1000m };
            case Units.Ounce:
                return new ResultModel { OriginalUnit = Units.Milligrams, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value / 16m / 2.20462m / 1000m / 1000m };
            case Units.Pound:
                return new ResultModel { OriginalUnit = Units.Milligrams, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value / 2.20462m / 1000m / 1000m };
            default:
                return new ResultModel { ErrorMessage = $"Error! Unknown UnitTo = {unitTo}" };
        }
    }

    private ResultModel GramTo(Units unitTo, Units unitFrom, decimal value)
    {
        switch (unitTo)
        {
            case Units.Milligrams:
                return new ResultModel { OriginalUnit = Units.Gram, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 1000m };
            case Units.Gram:
                return new ResultModel { OriginalUnit = Units.Gram, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value };
            case Units.Kilogram:
                return new ResultModel { OriginalUnit = Units.Gram, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value / 1000m };
            case Units.Ounce:
                return new ResultModel {OriginalUnit = Units.Gram, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value / 28.3495m };
            case Units.Pound:
                return new ResultModel { OriginalUnit = Units.Gram, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value / 2.20462m / 1000m };
            default:
                return new ResultModel { ErrorMessage = $"Error! Unknown UnitTo = {unitTo}" };
        }
    }

    private ResultModel KilogramTo(Units unitTo, Units unitFrom, decimal value)
    {
        switch (unitTo)
        {
            case Units.Milligrams:
                return new ResultModel { OriginalUnit = Units.Kilogram, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 1000m * 1000m };
            case Units.Gram:
                return new ResultModel { OriginalUnit = Units.Kilogram, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 1000m };
            case Units.Kilogram:
                return new ResultModel { OriginalUnit = Units.Kilogram, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value };
            case Units.Ounce:
                return new ResultModel { OriginalUnit = Units.Kilogram, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value / 16m / 2.20462m };
            case Units.Pound:
                return new ResultModel {OriginalUnit = Units.Kilogram, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 2.20462m };
            default:
                return new ResultModel { ErrorMessage = $"Error! Unknown UnitTo = {unitTo}" };
        }
    }

    private ResultModel OunceTo(Units unitTo, Units unitFrom, decimal value)
    {
        switch (unitTo)
        {
            case Units.Milligrams:
                return new ResultModel { OriginalUnit = Units.Ounce, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value / 16m / 2.20462m * 1000m * 1000m };
            case Units.Gram:
                return new ResultModel {OriginalUnit = Units.Ounce, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 28.3495m };
            case Units.Kilogram:
                return new ResultModel { OriginalUnit = Units.Ounce, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value / 16m / 2.20462m };
            case Units.Ounce:
                return new ResultModel { OriginalUnit = Units.Ounce, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value };
            case Units.Pound:
                return new ResultModel { OriginalUnit = Units.Ounce, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value / 16m };
            default:
                return new ResultModel { ErrorMessage = $"Error! Unknown UnitTo = {unitTo}" };
        }
    }

    private ResultModel PoundTo(Units unitTo, Units unitFrom, decimal value)
    {
        switch (unitTo)
        {
            case Units.Milligrams:
                return new ResultModel { OriginalUnit = Units.Pound, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 16m / 2.20462m * 1000m * 1000m };
            case Units.Gram:
                return new ResultModel { OriginalUnit = Units.Pound, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 16m / 2.20462m * 1000m };
            case Units.Kilogram:
                return new ResultModel { OriginalUnit = Units.Pound, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value / 2.20462m };
            case Units.Ounce:
                return new ResultModel { OriginalUnit = Units.Pound, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value * 16m };
            case Units.Pound:
                return new ResultModel { OriginalUnit = Units.Pound, OriginalValue = value, ConvertedUnit = unitTo, ConvertedValue = value };
            default:
                return new ResultModel { ErrorMessage = $"Error! Unknown UnitTo = {unitTo}" };
        }
    }
}