namespace ProductivityPulseAPI.Extensions
{
  public static class ApplicationBuilderExtensions
  {
    public static WebApplication ConfigurePipeline(this WebApplication app)
    {
      if (app.Environment.IsDevelopment())
      {
        app.UseSwagger();
        app.UseSwaggerUI();
      }

      app.UseHttpsRedirection();
      app.UseAuthorization();
      app.MapControllers();

      return app;
    }
  }
}