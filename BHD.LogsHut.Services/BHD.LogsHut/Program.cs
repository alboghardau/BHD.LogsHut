﻿using BHD.Logger.DeepCore;
using BHD.LogsHut.Utils;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://localhost:5000");

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDeepLogger(builder.Configuration);
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", corsPolicyBuilder =>
    {
        corsPolicyBuilder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

ServiceUtils.RegisterServices(builder);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseCors("AllowAll");

// app.UseHttpsRedirection();
//
// app.UseAuthorization();

app.MapControllers();

app.Run();


