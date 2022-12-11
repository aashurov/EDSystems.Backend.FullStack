using Newtonsoft.Json;

namespace EDSystems.Domain.Entities
{
    public class ParcelItem : BaseAuditableEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Cost { get; set; }
        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }

        [JsonIgnore]
        public Parcel Parcel { get; set; }
    }
}