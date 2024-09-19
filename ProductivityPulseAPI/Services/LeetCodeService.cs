using AutoMapper;
using ProductivityPulseAPI.Models.DTOs;
using ProductivityPulseAPI.Models.Entities;
using ProductivityPulseAPI.Services.Interfaces;

namespace ProductivityPulseAPI.Services
{
  public class LeetCodeService : ILeetCodeService
  {
    private readonly IMapper _mapper;

    public LeetCodeService(IMapper mapper)
    {
      _mapper = mapper;
    }

    public async Task<LeetCodeDailySummaryDto> GetDailySummaryAsync(DateTime date)
    {
      // Simulate some asynchronous work
      await Task.Delay(100);  // Simulates a 100ms delay

      var summary = new LeetCodeDailySummary
      {
        Date = date,
        TotalSolved = 10,  // Hardcoded value
        EasySolved = 5,    // Hardcoded value
        MediumSolved = 3,  // Hardcoded value
        HardSolved = 2,    // Hardcoded value
        TotalSubmissions = 15  // Hardcoded value
      };

      return _mapper.Map<LeetCodeDailySummaryDto>(summary);
    }
  }
}