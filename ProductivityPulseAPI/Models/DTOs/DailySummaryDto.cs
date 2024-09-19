namespace ProductivityPulseAPI.Models.DTOs
{
  public class DailySummaryDto
  {
    public DateTime Date { get; set; }
    public LeetCodeDailySummaryDto? LeetCode { get; set; }
  }
}