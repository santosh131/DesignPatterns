namespace Prototype.Models;

public class EmployeeAddress : BaseModel
{
    public int Id { get; set; }
    public string AddressLine1 { get; set; } = string.Empty;
    public string AddressLine2 { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string Zip { get; set; } = string.Empty;

    public override object Clone()
    {
        return this.MemberwiseClone();
    }
}