using ProductivityPulseAPI.Models.DTOs;

namespace ProductivityPulseAPI.Services.Interfaces
{
  public interface ILeetCodeService
  {
    Task<LeetCodeDailySummaryDto> GetDailySummaryAsync(DateTime date);
  }
}