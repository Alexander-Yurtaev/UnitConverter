using UnitConverter.Mvc.Converters;

namespace UnitConverter.Mvc.Services;

public class ConverterService
{
    private readonly IServiceProvider _serviceProvider;
    private readonly List<IConverter> _cachedConverters;

    public ConverterService(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        _cachedConverters = GetAllConverters().ToList();
    }

    public IEnumerable<IConverter> GetAllConverters()
    {
        // Получаем все сборки в приложении
        var assemblies = AppDomain.CurrentDomain.GetAssemblies();

        var assemblyTypes = assemblies.SelectMany(assembly => assembly.GetTypes());
        var converters = assemblyTypes.Where(type => type.IsInterface && typeof(IConverter).IsAssignableFrom(type));

        return converters.Select(type => _serviceProvider.GetService(type) as IConverter).OfType<IConverter>().ToList();
    }

    public IEnumerable<IConverter> GetCachedAllConverters()
    {
        return _cachedConverters;
    }
}