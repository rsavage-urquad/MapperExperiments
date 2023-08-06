using AutoMapper;

namespace MapperExperiments.Classes.Support;

/// <summary>
/// AutoMapperItemProfile Class - Configuration for AutoMapper, including Column Name differences and Reverse Mapping
/// </summary>
public class AutoMapperItemProfile : Profile
{
    public AutoMapperItemProfile()
    {
    CreateMap<SourceItem, TargetItem>()
        .ForMember(tgt => tgt.ZipCode, ex => ex.MapFrom(src => src.Zip))        // Map properties when name is different
        .ForMember(tgt => tgt.DOB, ex => ex.MapFrom(src => src.DateOfBirth))
        .ForMember("YearlyAmount", ex => ex.MapFrom("Salary"))                  // Can use Property Name (but no Intellisense)
        .ReverseMap();
    }
}