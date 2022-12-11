namespace EDSystems.Domain.Entities;

public class Plan : BaseAuditableEntity
{
    public string Name { get; set; }
    public decimal Cost { get; set; }
    public string Description { get; set; }
}