namespace UnitConverter.Mvc.Models;

public record ResultModel
{
    public decimal? ValueTo { get; set; }
    public string? Message { get; set; }
}