namespace EDSystems.Domain.Entities;

public class SmsDetails : BaseEntity
{
    public string Code { get; set; }
    public string Recepient { get; set; }
    public string Sender { get; set; }
    public string PhoneNumber { get; set; }
    public int Status { get; set; }
}