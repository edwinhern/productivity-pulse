namespace ProductivityPulseAPI.Models.DTOs
{
  public class LeetCodeDailySummaryDto
  {
    public DateTime Date { get; set; }
    public int TotalSolved { get; set; }
    public int EasySolved { get; set; }
    public int MediumSolved { get; set; }
    public int HardSolved { get; set; }
    public int TotalSubmissions { get; set; }
  }
}