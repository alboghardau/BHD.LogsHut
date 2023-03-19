using BHD.Logger.Interfaces;
using BHD.Logger.Mock;
using BHD.Logger.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddSingleton<LoggerService>();
builder.Services.AddTransient<IMockService, MockService>();
builder.Services.AddTransient<ILogGenerator, LogGenerator>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

