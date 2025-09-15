using UnitConverter.Mvc.Converters;

namespace UnitConverter.Mvc.Extensions
{
    public static class ConverterExtensions
    {
        public static IServiceCollection AddConverterFactory(this IServiceCollection service)
        {
            service.AddSingleton<IConverterFactory, ConverterFactory>();

            service.AddSingleton<ILengthConverter, LengthConverter>();
            service.AddSingleton<IWeightConverter, WeightConverter>();

            return service;
        }
    }
}
