using ProductivityPulseAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add application services and configurations
builder.Services
    .AddApplicationServices()
    .AddApplicationConfigurations();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.ConfigurePipeline();

app.Run();
