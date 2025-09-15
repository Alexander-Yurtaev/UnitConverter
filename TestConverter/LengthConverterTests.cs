using UnitConverter.Mvc.Models.Enums;

namespace TestConverter
{
    public class LengthConverterTests : BaseConverterFactoryTests
    {
        [Theory]
        [InlineData(Units.Millimeter, Units.Centimeter, 10, 1)]
        [InlineData(Units.Millimeter, Units.Meter, 1000, 1)]
        [InlineData(Units.Millimeter, Units.Kilometer, 1000000, 1)]
        [InlineData(Units.Millimeter, Units.Inch, 25.4, 1)]
        [InlineData(Units.Millimeter, Units.Foot, 304.8, 1)]
        [InlineData(Units.Millimeter, Units.Yard, 914.4, 1)]
        [InlineData(Units.Millimeter, Units.Mile, 1609344, 1)]
        public void MillimeterConverterTests(Units unitFrom, Units unitTo, decimal value, decimal expected)
        {
            BaseConverterTest(ConverterType.Length, unitFrom, unitTo, value, expected);
        }

        [Theory]
        [InlineData(Units.Centimeter, Units.Millimeter, 1, 10)]
        [InlineData(Units.Centimeter, Units.Meter, 100, 1)]
        [InlineData(Units.Centimeter, Units.Kilometer, 100000, 1)]
        [InlineData(Units.Centimeter, Units.Inch, 2.54, 1)]
        [InlineData(Units.Centimeter, Units.Foot, 30.48, 1)]
        [InlineData(Units.Centimeter, Units.Yard, 91.44, 1)]
        [InlineData(Units.Centimeter, Units.Mile, 160934.4, 1)]
        public void CentimeterConverterTests(Units unitFrom, Units unitTo, decimal value, decimal expected)
        {
            BaseConverterTest(ConverterType.Length, unitFrom, unitTo, value, expected);
        }

        [Theory]
        [InlineData(Units.Meter, Units.Millimeter, 1, 1000)]
        [InlineData(Units.Meter, Units.Centimeter, 1, 100)]
        [InlineData(Units.Meter, Units.Kilometer, 1000, 1)]
        [InlineData(Units.Meter, Units.Inch, 1, 39.37007874)]
        [InlineData(Units.Meter, Units.Foot, 1, 3.280839895013123)]
        [InlineData(Units.Meter, Units.Yard, 1, 1.093613)]
        [InlineData(Units.Meter, Units.Mile, 1609.344, 1)]
        public void MeterConverterTests(Units unitFrom, Units unitTo, decimal value, decimal expected)
        {
            BaseConverterTest(ConverterType.Length, unitFrom, unitTo, value, expected);
        }

        [Theory]
        [InlineData(Units.Kilometer, Units.Millimeter, 1, 1000000)]
        [InlineData(Units.Kilometer, Units.Centimeter, 1, 100000)]
        [InlineData(Units.Kilometer, Units.Meter, 1, 1000)]
        [InlineData(Units.Kilometer, Units.Inch, 1, 39370.0787401575)]
        [InlineData(Units.Kilometer, Units.Foot, 1, 3280.839895013123)]
        [InlineData(Units.Kilometer, Units.Yard, 1, 1093.613298)]
        [InlineData(Units.Kilometer, Units.Mile, 1, 0.621371)]
        public void KilometerConverterTests(Units unitFrom, Units unitTo, decimal value, decimal expected)
        {
            BaseConverterTest(ConverterType.Length, unitFrom, unitTo, value, expected);
        }

        [Theory]
        [InlineData(Units.Inch, Units.Millimeter, 1, 25.4)]
        [InlineData(Units.Inch, Units.Centimeter, 1, 2.54)]
        [InlineData(Units.Inch, Units.Meter, 39.37, 1)]
        [InlineData(Units.Inch, Units.Kilometer, 39370.1, 1)]
        [InlineData(Units.Inch, Units.Foot, 12, 1)]
        [InlineData(Units.Inch, Units.Yard, 36, 1)]
        [InlineData(Units.Inch, Units.Mile, 63360, 1)]
        public void InchConverterTests(Units unitFrom, Units unitTo, decimal value, decimal expected)
        {
            BaseConverterTest(ConverterType.Length, unitFrom, unitTo, value, expected);
        }

        [Theory]
        [InlineData(Units.Foot, Units.Millimeter, 1, 304.8)]
        [InlineData(Units.Foot, Units.Centimeter, 1, 30.48)]
        [InlineData(Units.Foot, Units.Meter, 3.28084, 1)]
        [InlineData(Units.Foot, Units.Kilometer, 3280.84, 1)]
        [InlineData(Units.Foot, Units.Inch, 1, 12)]
        [InlineData(Units.Foot, Units.Yard, 3, 1)]
        [InlineData(Units.Foot, Units.Mile, 5280, 1)]
        public void FootConverterTests(Units unitFrom, Units unitTo, decimal value, decimal expected)
        {
            BaseConverterTest(ConverterType.Length, unitFrom, unitTo, value, expected);
        }

        [Theory]
        [InlineData(Units.Yard, Units.Millimeter, 1, 914.4)]
        [InlineData(Units.Yard, Units.Centimeter, 1, 91.44)]
        [InlineData(Units.Yard, Units.Meter, 1, 0.9144)]
        [InlineData(Units.Yard, Units.Kilometer, 1093.61, 1)]
        [InlineData(Units.Yard, Units.Inch, 1, 36)]
        [InlineData(Units.Yard, Units.Foot, 1, 3)]
        [InlineData(Units.Yard, Units.Mile, 1760, 1)]
        public void YardConverterTests(Units unitFrom, Units unitTo, decimal value, decimal expected)
        {
            BaseConverterTest(ConverterType.Length, unitFrom, unitTo, value, expected);
        }

        [Theory]
        [InlineData(Units.Mile, Units.Millimeter, 1, 1609344)]
        [InlineData(Units.Mile, Units.Centimeter, 1, 160934.4)]
        [InlineData(Units.Mile, Units.Meter, 1, 1609.344)]
        [InlineData(Units.Mile, Units.Kilometer,1, 1.609344)]
        [InlineData(Units.Mile, Units.Inch, 1, 63360)]
        [InlineData(Units.Mile, Units.Foot, 1, 5280)]
        [InlineData(Units.Mile, Units.Yard, 1, 1760)]
        public void MileConverterTests(Units unitFrom, Units unitTo, decimal value, decimal expected)
        {
            BaseConverterTest(ConverterType.Length, unitFrom, unitTo, value, expected);
        }

        // Дополнительные тестовые случаи с разными значениями
        [Theory]
        [InlineData(Units.Meter, Units.Foot, 2, 6.56167979)] // 2 метра в футы
        [InlineData(Units.Kilometer, Units.Mile, 2, 1.242742)] // 2 км в мили
        [InlineData(Units.Inch, Units.Centimeter, 5, 12.7)] // 5 дюймов в сантиметры
        [InlineData(Units.Yard, Units.Meter, 5, 4.572)] // 5 ярдов в метры
        [InlineData(Units.Mile, Units.Kilometer, 0.5, 0.804672)] // 0.5 мили в километры
        public void AdditionalConverterTests(Units unitFrom, Units unitTo, decimal value, decimal expected)
        {
            BaseConverterTest(ConverterType.Length, unitFrom, unitTo, value, expected);
        }

        // Краевые случаи
        [Theory]
        [InlineData(Units.Millimeter, Units.Millimeter, 1, 1)] // самоконверсия
        [InlineData(Units.Centimeter, Units.Centimeter, 10, 10)]
        [InlineData(Units.Meter, Units.Meter, 100, 100)]
        [InlineData(Units.Kilometer, Units.Kilometer, 1000, 1000)]
        [InlineData(Units.Inch, Units.Inch, 100, 100)]
        [InlineData(Units.Foot, Units.Foot, 100, 100)]
        [InlineData(Units.Yard, Units.Yard, 100, 100)]
        [InlineData(Units.Mile, Units.Mile, 100, 100)]
        public void EdgeCasesConverter(Units unitFrom, Units unitTo, decimal value, decimal expected)
        {
            BaseConverterTest(ConverterType.Length, unitFrom, unitTo, value, expected);
        }
    }
}
