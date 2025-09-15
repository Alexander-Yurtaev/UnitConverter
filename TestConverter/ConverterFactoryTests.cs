using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using UnitConverter.Mvc.Extensions;
using UnitConverter.Mvc.Models.Enums;
using UnitConverter.Mvc.Utils;

namespace TestConverter
{
    public class ConverterFactoryTests
    {
        private readonly IConverterFactory _factory;

        public ConverterFactoryTests()
        {
            var services = new ServiceCollection();
            services.AddConverterFactory();
            IServiceProvider provider = services.BuildServiceProvider();
            _factory = provider.GetRequiredService<IConverterFactory>();
        }

        [Theory]
        [InlineData(LengthUnit.Millimeter, LengthUnit.Centimeter, 10, 1)]
        [InlineData(LengthUnit.Millimeter, LengthUnit.Meter, 1000, 1)]
        [InlineData(LengthUnit.Millimeter, LengthUnit.Kilometer, 1000000, 1)]
        [InlineData(LengthUnit.Millimeter, LengthUnit.Inch, 25.4, 1)]
        [InlineData(LengthUnit.Millimeter, LengthUnit.Foot, 304.8, 1)]
        [InlineData(LengthUnit.Millimeter, LengthUnit.Yard, 914.4, 1)]
        [InlineData(LengthUnit.Millimeter, LengthUnit.Mile, 1609344, 1)]

        [InlineData(LengthUnit.Centimeter, LengthUnit.Millimeter, 1, 10)]
        [InlineData(LengthUnit.Centimeter, LengthUnit.Meter, 100, 1)]
        [InlineData(LengthUnit.Centimeter, LengthUnit.Kilometer, 100000, 1)]
        [InlineData(LengthUnit.Centimeter, LengthUnit.Inch, 2.54, 1)]
        [InlineData(LengthUnit.Centimeter, LengthUnit.Foot, 30.48, 1)]
        [InlineData(LengthUnit.Centimeter, LengthUnit.Yard, 91.44, 1)]
        [InlineData(LengthUnit.Centimeter, LengthUnit.Mile, 160934.4, 1)]

        [InlineData(LengthUnit.Meter, LengthUnit.Millimeter, 1, 1000)]
        [InlineData(LengthUnit.Meter, LengthUnit.Centimeter, 1, 100)]
        [InlineData(LengthUnit.Meter, LengthUnit.Kilometer, 1000, 1)]
        [InlineData(LengthUnit.Meter, LengthUnit.Inch, 1, 39.37007874)]
        [InlineData(LengthUnit.Meter, LengthUnit.Foot, 1, 3.280839895013123)]
        [InlineData(LengthUnit.Meter, LengthUnit.Yard, 1, 1.093613)]
        [InlineData(LengthUnit.Meter, LengthUnit.Mile, 1609.344, 1)]

        [InlineData(LengthUnit.Kilometer, LengthUnit.Millimeter, 1, 1000000)]
        [InlineData(LengthUnit.Kilometer, LengthUnit.Centimeter, 1, 100000)]
        [InlineData(LengthUnit.Kilometer, LengthUnit.Meter, 1, 1000)]
        [InlineData(LengthUnit.Kilometer, LengthUnit.Inch, 1, 39370.0787401575)]
        [InlineData(LengthUnit.Kilometer, LengthUnit.Foot, 1, 3280.839895013123)]
        [InlineData(LengthUnit.Kilometer, LengthUnit.Yard, 1, 1093.613298)]
        [InlineData(LengthUnit.Kilometer, LengthUnit.Mile, 1, 0.621371)]

        [InlineData(LengthUnit.Inch, LengthUnit.Millimeter, 1, 25.4)]
        [InlineData(LengthUnit.Inch, LengthUnit.Centimeter, 1, 2.54)]
        [InlineData(LengthUnit.Inch, LengthUnit.Meter, 39.37, 1)]
        [InlineData(LengthUnit.Inch, LengthUnit.Kilometer, 39370.1, 1)]
        [InlineData(LengthUnit.Inch, LengthUnit.Foot, 12, 1)]
        [InlineData(LengthUnit.Inch, LengthUnit.Yard, 36, 1)]
        [InlineData(LengthUnit.Inch, LengthUnit.Mile, 63360, 1)]

        [InlineData(LengthUnit.Foot, LengthUnit.Millimeter, 1, 304.8)]
        [InlineData(LengthUnit.Foot, LengthUnit.Centimeter, 1, 30.48)]
        [InlineData(LengthUnit.Foot, LengthUnit.Meter, 3.28084, 1)]
        [InlineData(LengthUnit.Foot, LengthUnit.Kilometer, 3280.84, 1)]
        [InlineData(LengthUnit.Foot, LengthUnit.Inch, 1, 12)]
        [InlineData(LengthUnit.Foot, LengthUnit.Yard, 3, 1)]
        [InlineData(LengthUnit.Foot, LengthUnit.Mile, 5280, 1)]

        [InlineData(LengthUnit.Yard, LengthUnit.Millimeter, 1, 914.4)]
        [InlineData(LengthUnit.Yard, LengthUnit.Centimeter, 1, 91.44)]
        [InlineData(LengthUnit.Yard, LengthUnit.Meter, 1, 0.9144)]
        [InlineData(LengthUnit.Yard, LengthUnit.Kilometer, 1093.61, 1)]
        [InlineData(LengthUnit.Yard, LengthUnit.Inch, 1, 36)]
        [InlineData(LengthUnit.Yard, LengthUnit.Foot, 1, 3)]
        [InlineData(LengthUnit.Yard, LengthUnit.Mile, 1760, 1)]

        [InlineData(LengthUnit.Mile, LengthUnit.Millimeter, 1, 1609344)]
        [InlineData(LengthUnit.Mile, LengthUnit.Centimeter, 1, 160934.4)]
        [InlineData(LengthUnit.Mile, LengthUnit.Meter, 1, 1609.344)]
        [InlineData(LengthUnit.Mile, LengthUnit.Kilometer,1, 1.609344)]
        [InlineData(LengthUnit.Mile, LengthUnit.Inch, 1, 63360)]
        [InlineData(LengthUnit.Mile, LengthUnit.Foot, 1, 5280)]
        [InlineData(LengthUnit.Mile, LengthUnit.Yard, 1, 1760)]

        // Дополнительные тестовые случаи с разными значениями
        [InlineData(LengthUnit.Meter, LengthUnit.Foot, 2, 6.56167979)] // 2 метра в футы
        [InlineData(LengthUnit.Kilometer, LengthUnit.Mile, 2, 1.242742)] // 2 км в мили
        [InlineData(LengthUnit.Inch, LengthUnit.Centimeter, 5, 12.7)] // 5 дюймов в сантиметры
        [InlineData(LengthUnit.Yard, LengthUnit.Meter, 5, 4.572)] // 5 ярдов в метры
        [InlineData(LengthUnit.Mile, LengthUnit.Kilometer, 0.5, 0.804672)] // 0.5 мили в километры

        // Краевые случаи
        [InlineData(LengthUnit.Millimeter, LengthUnit.Millimeter, 1, 1)] // самоконверсия
        [InlineData(LengthUnit.Centimeter, LengthUnit.Centimeter, 10, 10)]
        [InlineData(LengthUnit.Meter, LengthUnit.Meter, 100, 100)]
        [InlineData(LengthUnit.Kilometer, LengthUnit.Kilometer, 1000, 1000)]
        [InlineData(LengthUnit.Inch, LengthUnit.Inch, 100, 100)]
        [InlineData(LengthUnit.Foot, LengthUnit.Foot, 100, 100)]
        [InlineData(LengthUnit.Yard, LengthUnit.Yard, 100, 100)]
        [InlineData(LengthUnit.Mile, LengthUnit.Mile, 100, 100)]
        public void Converter(LengthUnit unitFrom, LengthUnit unitTo, decimal value, decimal expected)
        {
            // Arrange
            var converter = _factory.GetConverter(ConverterType.Length);

            // Act
            var actual = converter.Convert(unitFrom, unitTo, value);

            // Assert
            actual.Should().NotBeNull();
            actual.ValueTo.Should().NotBeNull();
            actual.ValueTo.Should().BeApproximately(expected, 0.00001m, $"{unitFrom} -> {unitTo}: {value} -> {actual.ValueTo} -> {expected}");
        }
    }
}
