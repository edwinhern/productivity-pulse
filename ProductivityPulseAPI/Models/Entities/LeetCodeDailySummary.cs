namespace ProductivityPulseAPI.Models.Entities
{
  public class LeetCodeDailySummary
  {
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int TotalSolved { get; set; }
    public int EasySolved { get; set; }
    public int MediumSolved { get; set; }
    public int HardSolved { get; set; }
    public int TotalSubmissions { get; set; }
  }
}