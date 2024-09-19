using Microsoft.AspNetCore.Mvc;
using ProductivityPulseAPI.Models.DTOs;
using ProductivityPulseAPI.Services.Interfaces;

namespace ProductivityPulseAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class SummaryController : ControllerBase
{
  private readonly ILeetCodeService _leetCodeService;

  public SummaryController(ILeetCodeService leetCodeService)
  {
    _leetCodeService = leetCodeService;
  }

  [HttpGet("daily")]
  public async Task<ActionResult<DailySummaryDto>> GetDaily([FromQuery] DateTime? dateTime)
  {
    var targetDate = dateTime ?? DateTime.UtcNow.Date;
    var leetCodeSummary = await _leetCodeService.GetDailySummaryAsync(targetDate);

    var dailySummary = new DailySummaryDto
    {
      Date = targetDate,
      LeetCode = leetCodeSummary
    };

    return Ok(dailySummary);
  }
}