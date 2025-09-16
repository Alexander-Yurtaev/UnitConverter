using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using UnitConverter.Mvc.Converters;
using UnitConverter.Mvc.Extensions;
using UnitConverter.Mvc.Models.Enums;

namespace TestConverter;

public class BaseConverterFactoryTests
{
    protected readonly IConverterFactory Factory;

    public BaseConverterFactoryTests()
    {
        var services = new ServiceCollection();
        services.AddConverterFactory();
        IServiceProvider provider = services.BuildServiceProvider();
        Factory = provider.GetRequiredService<IConverterFactory>();
    }

    protected void BaseConverterTest(ConverterType converterType, Units unitFrom, Units unitTo, decimal value, decimal expected)
    {
        // Arrange
        var converter = Factory.GetConverter(converterType);

        // Act
        var actual = converter.Convert(unitFrom, unitTo, value);

        // Assert
        actual.Should().NotBeNull();
        actual.ConvertedValue.Should().NotBeNull();
        actual.ConvertedValue.Should().BeApproximately(expected, 0.00001m, $"{unitFrom} -> {unitTo}: {value} -> {actual.ConvertedValue} -> {expected}");
    }
}