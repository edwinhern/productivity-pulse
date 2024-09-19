using ProductivityPulseAPI.Configurations;
using ProductivityPulseAPI.Services;
using ProductivityPulseAPI.Services.Interfaces;

namespace ProductivityPulseAPI.Extensions
{
  public static class ServiceCollectionExtensions
  {
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
      services.AddScoped<ILeetCodeService, LeetCodeService>();
      return services;
    }

    public static IServiceCollection AddApplicationConfigurations(this IServiceCollection services)
    {
      services.AddAutoMapper(typeof(AutoMapperProfile));
      services.AddHttpClient();
      return services;
    }
  }
}