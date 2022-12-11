using EDSystems.Domain.Entities.UserEntities;
using System.Collections.Generic;

namespace EDSystems.Domain.Entities;

public class UserAccount : BaseAuditableEntity
{
    public string Number { get; set; }
    public string Name { get; set; }
    public decimal Balance { get; set; }
    public string UserId { get; set; }
    public User User { get; set; }
    public int CurrencyId { get; set; }
    public Currency Currency { get; set; }
    public ICollection<UserAccountHistory> UserAccountHistory { get; set; }
}