// Ignore Spelling: Mapperly

using Riok.Mapperly.Abstractions;

namespace MapperExperiments.Classes.Support;

/// <summary>
/// MapperlyItemMapper Class - Configuration for Mapperly, including Column Name differences and Reverse Mapping
/// </summary>
[Mapper]
public partial class MapperlyItemMapper
{
    [MapProperty(nameof(SourceItem.Zip), nameof(TargetItem.ZipCode))]
    [MapProperty(nameof(SourceItem.DateOfBirth), nameof(TargetItem.DOB))]
    [MapProperty(nameof(SourceItem.Salary), nameof(TargetItem.YearlyAmount))]
    public partial TargetItem SourceItemToTargetItem(SourceItem source);

    [MapProperty(nameof(TargetItem.ZipCode), nameof(SourceItem.Zip))]
    [MapProperty(nameof(TargetItem.DOB), nameof(SourceItem.DateOfBirth))]
    [MapProperty(nameof(TargetItem.YearlyAmount), nameof(SourceItem.Salary))]
    public partial SourceItem TargetItemToSourceItem(TargetItem target);
}


