using ProductivityPulseAPI.Models.Entities;

namespace ProductivityPulseAPI.Repositories.Interfaces
{
  public interface ILeetCodeRepository
  {
    Task<LeetCodeDailySummary> GetDailySummaryAsync(DateTime date);
    Task SaveDailySummaryAsync(LeetCodeDailySummary dailySummary);
  }
}