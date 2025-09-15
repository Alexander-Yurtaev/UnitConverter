using UnitConverter.Mvc.Models.Enums;

namespace UnitConverter.Mvc.Converters;

public class ConverterFactory : IConverterFactory
{
    private readonly IServiceProvider _serviceProvider;

    public ConverterFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public IConverter GetConverter(ConverterType converterType)
    {
        switch (converterType)
        {
            case ConverterType.Length:
                return _serviceProvider.GetRequiredService<ILengthConverter>();
            case ConverterType.Weight:
                return _serviceProvider.GetRequiredService<IWeightConverter>();
            case ConverterType.Temperature:
                return _serviceProvider.GetRequiredService<ITemperatureConverter>();
            default:
                throw new ArgumentOutOfRangeException(nameof(converterType), converterType, null);
        }
    }
}