namespace MapperExperiments.Classes;

/// <summary>
/// TargetItem Class - Target Info Properties
/// </summary>
public class TargetItem
{
    public int InfoId { get; set; }
    public string PersonName { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public DateTime DOB { get; set; }
    public Decimal YearlyAmount { get; set; }

    /// <summary>
    /// TargetItem() - Default Constructor
    /// </summary>
    public TargetItem()
    {
        InfoId = 0;
        PersonName = "";
        City = "";
        State = "";
        ZipCode = "";
        DOB = DateTime.MinValue;
        YearlyAmount = 0.00M;
    }
}
