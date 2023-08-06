namespace MapperExperiments.Classes;

/// <summary>
/// SourceItem Class - Source Info Properties
/// </summary>
public class SourceItem
{
    public int InfoId { get; set; }
    public string PersonName { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Decimal Salary { get; set; }

    /// <summary>
    /// SourceItem() - Default Constructor
    /// </summary>
    public SourceItem()
    {
        InfoId = 0;
        PersonName = "";
        City = "";
        State = "";
        Zip = "";
        DateOfBirth = DateTime.MinValue;
        Salary = 0.00M;
    }
}
