using UnitConverter.Mvc.Models.Enums;

namespace UnitConverter.Mvc.Models
{
    public record FormModel
    {
        public int UnitFrom { get; set; }
        public int UnitTo { get; set; }
        public decimal ValueFrom { get; set; }
        public List<UnitItem> UnitItems { get; set; } = new List<UnitItem>();

        public bool IsValid()
        {
            return Enum.IsDefined(typeof(Units), UnitFrom) &&
                   Enum.IsDefined(typeof(Units), UnitTo);
        }
    }
}
