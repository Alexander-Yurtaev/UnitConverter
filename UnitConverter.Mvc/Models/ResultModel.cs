using UnitConverter.Mvc.Models.Enums;

namespace UnitConverter.Mvc.Models;

public record ResultModel
{
    public Units OriginalUnit { get; set; }
    public decimal OriginalValue { get; set; }
    
    public Units ConvertedUnit { get; set; }
    public decimal? ConvertedValue { get; set; }

    public string? ErrorMessage { get; set; }
}