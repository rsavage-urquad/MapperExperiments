// Ignore Spelling: Mapperly
using AutoMapper;
using MapperExperiments.Classes.Interfaces;

namespace MapperExperiments.Classes.Mappers;

public class AutoMapperTest : IAutoMapperTest
{
    private readonly IMapper _mapper;

    public AutoMapperTest(IMapper mapper)
    {
        _mapper = mapper;
    }

    /// <summary>
    /// MapSourceToTarget() - Use AutoMapper to map the columns from the Source to the Target object
    /// </summary>
    /// <param name="sourceItem">Source item</param>
    /// <returns>Target item</returns>
    public TargetItem MapSourceToTarget(SourceItem sourceItem)
    {
        TargetItem targetItem = _mapper.Map<TargetItem>(sourceItem);
        return targetItem;
    }

    /// <summary>
    /// MapTargetToSource() - Use AutoMapper to map the columns from the Target to the Source object
    /// </summary>
    /// <param name="targetItem">Target Item</param>
    /// <returns>Source Item</returns>
    public SourceItem MapTargetToSource(TargetItem targetItem)
    {
        SourceItem sourceItem = _mapper.Map<SourceItem>(targetItem);
        return sourceItem;
    }
}
