//using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace EDSystems.Domain.Entities;

public class ParcelImage : BaseAuditableEntity
{
    [JsonIgnore]
    public string ImageName { get; set; }

    public string ImageBytes { get; set; }

    [JsonIgnore]
    public Parcel Parcel { get; set; }
}