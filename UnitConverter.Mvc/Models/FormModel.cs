namespace UnitConverter.Mvc.Models
{
    public record FormModel
    {
        public int UnitFrom { get; set; }
        public int UnitTo { get; set; }
        public decimal ValueFrom { get; set; }
        public List<UnitItem> UnitItems { get; set; } = new List<UnitItem>();
    }
}
