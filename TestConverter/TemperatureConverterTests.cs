using UnitConverter.Mvc.Models.Enums;

namespace TestConverter
{
    public class TemperatureConverterTests : BaseConverterFactoryTests
    {
        // Celsius <-> Fahrenheit
        [Theory]
        [InlineData(Units.Celsius, Units.Fahrenheit, 0, 32)] // 0°C = 32°F
        [InlineData(Units.Celsius, Units.Fahrenheit, 100, 212)] // 100°C = 212°F
        [InlineData(Units.Celsius, Units.Fahrenheit, -40, -40)] // -40°C = -40°F
        [InlineData(Units.Celsius, Units.Fahrenheit, 37, 98.6)] // 37°C = 98.6°F

        [InlineData(Units.Fahrenheit, Units.Celsius, 32, 0)] // 32°F = 0°C
        [InlineData(Units.Fahrenheit, Units.Celsius, 212, 100)] // 212°F = 100°C
        [InlineData(Units.Fahrenheit, Units.Celsius, -40, -40)] // -40°F = -40°C
        [InlineData(Units.Fahrenheit, Units.Celsius, 98.6, 37)] // 98.6°F = 37°C
        public void CelsiusFahrenheitConverter(Units unitFrom, Units unitTo, decimal value, decimal expected)
        {
            BaseConverterTest(ConverterType.Temperature, unitFrom, unitTo, value, expected);
        }

        // Celsius <-> Kelvin
        [Theory]
        [InlineData(Units.Celsius, Units.Kelvin, 0, 273.15)] // 0°C = 273.15K
        [InlineData(Units.Celsius, Units.Kelvin, 100, 373.15)] // 100°C = 373.15K
        [InlineData(Units.Celsius, Units.Kelvin, -273.15, 0)] // Абсолютный ноль

        [InlineData(Units.Kelvin, Units.Celsius, 273.15, 0)] // 273.15K = 0°C
        [InlineData(Units.Kelvin, Units.Celsius, 373.15, 100)] // 373.15K = 100°C
        [InlineData(Units.Kelvin, Units.Celsius, 0, -273.15)] // 0K = -273.15°C
        public void CelsiusKelvinConverter(Units unitFrom, Units unitTo, decimal value, decimal expected)
        {
            BaseConverterTest(ConverterType.Temperature, unitFrom, unitTo, value, expected);
        }

        // Fahrenheit <-> Kelvin
        [Theory]
        [InlineData(Units.Fahrenheit, Units.Kelvin, 32, 273.15)] // 32°F = 273.15K
        [InlineData(Units.Fahrenheit, Units.Kelvin, 212, 373.15)] // 212°F = 373.15K

        [InlineData(Units.Kelvin, Units.Fahrenheit, 273.15, 32)] // 273.15K = 32°F
        [InlineData(Units.Kelvin, Units.Fahrenheit, 373.15, 212)] // 373.15K = 212°F
        public void FahrenheitKelvinConverter(Units unitFrom, Units unitTo, decimal value, decimal expected)
        {
            BaseConverterTest(ConverterType.Temperature, unitFrom, unitTo, value, expected);
        }

        // Граничные значения
        [Theory]
        [InlineData(Units.Celsius, Units.Celsius, 0, 0)] // 0°C = 0°C
        [InlineData(Units.Fahrenheit, Units.Fahrenheit, 32, 32)] // 32°F = 32°F
        [InlineData(Units.Kelvin, Units.Kelvin, 273.15, 273.15)] // 273.15K = 273.15K

        // Десятичные значения
        [InlineData(Units.Celsius, Units.Fahrenheit, 25.5, 77.9)] // 25.5°C = 77.9°F
        [InlineData(Units.Kelvin, Units.Celsius, 293.15, 20)] // 293.15K = 20°C
        public void EdgeCasesConverter(Units unitFrom, Units unitTo, decimal value, decimal expected)
        {
            BaseConverterTest(ConverterType.Temperature, unitFrom, unitTo, value, expected);
        }
    }
}
