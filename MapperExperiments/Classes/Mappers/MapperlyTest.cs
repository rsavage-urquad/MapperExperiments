// Ignore Spelling: Mapperly

using MapperExperiments.Classes.Support;

namespace MapperExperiments.Classes.Mappers;

public class MapperlyTest
{
    /// <summary>
    /// MapSourceToTarget() - Use Mapperly to map the columns from the Source to the Target object
    /// </summary>
    /// <param name="sourceItem">Source item</param>
    /// <returns>Target item</returns>
    public TargetItem MapSourceToTarget(SourceItem sourceItem)
    {
        var mapper  = new MapperlyItemMapper();
        TargetItem targetItem = mapper.SourceItemToTargetItem(sourceItem);
        return targetItem;
    }

    /// <summary>
    /// MapTargetToSource() - Use Mapperly to map the columns from the Target to the Source object
    /// </summary>
    /// <param name="targetItem">Target Item</param>
    /// <returns>Source Item</returns>
    public SourceItem MapTargetToSource(TargetItem targetItem)
    {
        var mapper = new MapperlyItemMapper();
        SourceItem sourceItem = mapper.TargetItemToSourceItem(targetItem);
        return sourceItem;
    }
}
