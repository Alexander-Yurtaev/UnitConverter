using UnitConverter.Mvc.Models.Enums;

namespace TestConverter
{
    public class WeightConverterTests : BaseConverterFactoryTests
    {
        [Theory]
        // Миллиграммы <-> Граммы
        [InlineData(Units.Milligrams, Units.Gram, 1000, 1)] // 1000 мг = 1 г
        [InlineData(Units.Milligrams, Units.Gram, 500, 0.5)] // 500 мг = 0.5 г
        [InlineData(Units.Milligrams, Units.Gram, 1, 0.001)] // 1 мг = 0.001 г
        [InlineData(Units.Gram, Units.Milligrams, 1, 1000)] // 1 г = 1000 мг
        [InlineData(Units.Gram, Units.Milligrams, 0.5, 500)] // 0.5 г = 500 мг
        public void MilligramsGramConverter(Units unitFrom, Units unitTo, decimal value, decimal expected)
        {
            BaseConverterTest(ConverterType.Weight, unitFrom, unitTo, value, expected);
        }

        // Граммы <-> Килограммы
        [Theory]
        [InlineData(Units.Gram, Units.Kilogram, 1000, 1)] // 1000 г = 1 кг
        [InlineData(Units.Gram, Units.Kilogram, 500, 0.5)] // 500 г = 0.5 кг
        [InlineData(Units.Gram, Units.Kilogram, 1, 0.001)] // 1 г = 0.001 кг
        [InlineData(Units.Kilogram, Units.Gram, 1, 1000)] // 1 кг = 1000 г
        [InlineData(Units.Kilogram, Units.Gram, 0.5, 500)] // 0.5 кг = 500 г
        public void GramKilogramConverter(Units unitFrom, Units unitTo, decimal value, decimal expected)
        {
            BaseConverterTest(ConverterType.Weight, unitFrom, unitTo, value, expected);
        }

        // Унции <-> Фунты
        [Theory]
        [InlineData(Units.Ounce, Units.Pound, 16, 1)] // 16 унций = 1 фунт
        [InlineData(Units.Ounce, Units.Pound, 8, 0.5)] // 8 унций = 0.5 фунта
        [InlineData(Units.Ounce, Units.Pound, 1, 0.0625)] // 1 унция = 0.0625 фунта
        [InlineData(Units.Pound, Units.Ounce, 1, 16)] // 1 фунт = 16 унций
        [InlineData(Units.Pound, Units.Ounce, 0.5, 8)] // 0.5 фунта = 8 унций
        public void OuncePoundConverter(Units unitFrom, Units unitTo, decimal value, decimal expected)
        {
            BaseConverterTest(ConverterType.Weight, unitFrom, unitTo, value, expected);
        }

        // Метрическая <-> Имперская система
        [Theory]
        [InlineData(Units.Gram, Units.Ounce, 28.3495, 1)] // 28.3495 г = 1 унция
        [InlineData(Units.Kilogram, Units.Pound, 0.453592, 1)] // 0.453592 кг = 1 фунт
        [InlineData(Units.Ounce, Units.Gram, 1, 28.3495)] // 1 унция = 28.3495 г
        [InlineData(Units.Pound, Units.Kilogram, 1, 0.453592)] // 1 фунт = 0.453592 кг
        public void MetricImperialConverter(Units unitFrom, Units unitTo, decimal value, decimal expected)
        {
            BaseConverterTest(ConverterType.Weight, unitFrom, unitTo, value, expected);
        }

        // Граничные значения
        [Theory]
        [InlineData(Units.Milligrams, Units.Milligrams, 0, 0)] // 0 мг = 0 мг
        [InlineData(Units.Kilogram, Units.Kilogram, 1000, 1000)] // 1000 кг = 1000 кг
        [InlineData(Units.Pound, Units.Pound, 200, 200)] // 200 фунтов = 200 фунтов
        public void EdgeCasesConverter(Units unitFrom, Units unitTo, decimal value, decimal expected)
        {
            BaseConverterTest(ConverterType.Weight, unitFrom, unitTo, value, expected);
        }
    }
}
