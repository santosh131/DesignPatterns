namespace Prototype.Models;
public class EmployeeModel : BaseModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateOnly DateofBirth { get; set; }
    public EmployeeAddress EmployeeAddress { get; set; } =new EmployeeAddress();

    public override object Clone()
    {
        return this.MemberwiseClone();
    }
}