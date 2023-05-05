using BHD.Logger.Interfaces;
using BHD.Logger.Mock;
using BHD.Logger.Services;
using BHD.Logger.Utils;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

ServiceUtils.RegisterServices(builder);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


