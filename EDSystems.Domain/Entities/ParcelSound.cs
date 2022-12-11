using Newtonsoft.Json;

namespace EDSystems.Domain.Entities
{
    public class ParcelSound : BaseAuditableEntity
    {
        public string SoundName { get; set; }

        public string SoundBytes { get; set; }

        [JsonIgnore]
        public Parcel Parcel { get; set; }
    }
}