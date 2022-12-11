namespace EDSystems.Domain.Entities;

public class Currency : BaseAuditableEntity
{
    public string Name { get; set; }
    public string Code { get; set; }
    public int Number { get; set; }
    public string Country { get; set; }
}