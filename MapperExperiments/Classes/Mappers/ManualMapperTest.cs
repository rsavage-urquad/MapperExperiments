namespace MapperExperiments.Classes.Mappers;

public class ManualMapperTest
{
    /// <summary>
    /// MapSourceToTarget() - Manually maps the columns from the Source to the Target object
    /// </summary>
    /// <param name="sourceItem">Source Item</param>
    /// <returns>Target Item</returns>
    public TargetItem MapSourceToTarget(SourceItem sourceItem)
    {
        TargetItem targetItem = new TargetItem();
        targetItem.InfoId = sourceItem.InfoId;
        targetItem.PersonName = sourceItem.PersonName;
        targetItem.City = sourceItem.City;
        targetItem.State = sourceItem.State;
        targetItem.ZipCode = sourceItem.Zip;
        targetItem.DOB = sourceItem.DateOfBirth;
        targetItem.YearlyAmount = sourceItem.Salary;
        return targetItem;
    }

    /// <summary>
    /// MapTargetToSource() - Manually maps the columns from the Target to the Source object
    /// </summary>
    /// <param name="targetItem">Target Item</param>
    /// <returns>Source Item</returns>
    public SourceItem MapTargetToSource(TargetItem targetItem)
    {
        SourceItem sourceItem = new SourceItem();
        sourceItem.InfoId = targetItem.InfoId;
        sourceItem.PersonName = targetItem.PersonName;
        sourceItem.City = targetItem.City; 
        sourceItem.State = targetItem.State;
        sourceItem.Zip = targetItem.ZipCode;
        sourceItem.DateOfBirth = targetItem.DOB;
        sourceItem.Salary = targetItem.YearlyAmount;
        return sourceItem;
    }
}
