namespace Prototype.Models;
public class ManagerModel : BaseModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateOnly DateofBirth { get; set; }
    public ManagerAddressModel ManagerAddress { get; set; }=new ManagerAddressModel();

    public override object Clone()
    {
        ManagerModel manager = (ManagerModel)this.MemberwiseClone();
        manager.ManagerAddress = (ManagerAddressModel)this.ManagerAddress.Clone();
        return manager;
    }
}