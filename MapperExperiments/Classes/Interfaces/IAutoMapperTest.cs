namespace MapperExperiments.Classes.Interfaces;

public interface IAutoMapperTest
{
    TargetItem MapSourceToTarget(SourceItem sourceItem);
    SourceItem MapTargetToSource(TargetItem targetItem);
}
