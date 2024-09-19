using AutoMapper;
using ProductivityPulseAPI.Models.DTOs;
using ProductivityPulseAPI.Models.Entities;

namespace ProductivityPulseAPI.Configurations
{
  public class AutoMapperProfile : Profile
  {
    public AutoMapperProfile()
    {
      CreateMap<LeetCodeDailySummary, LeetCodeDailySummaryDto>().ReverseMap();
    }
  }
}