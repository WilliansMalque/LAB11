using AutoMapper;
using LAB11_WilliansMalque.Application.Commands;
using LAB11_WilliansMalque.Infrastructure.Models;

namespace LAB11_WilliansMalque.Application;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<AddResponseCommand, response>()
            .ForMember(dest => dest.response_id, opt => opt.Ignore())
            .ForMember(dest => dest.created_at, opt => opt.Ignore());
    }
}