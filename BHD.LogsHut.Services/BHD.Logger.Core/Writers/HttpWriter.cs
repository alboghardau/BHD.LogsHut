using System.Text;
using BHD.Logger.Library.Core;
using BHD.Logger.Library.Models;

namespace BHD.Logger.Library.Writers;

public class HttpWriter
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly LoggerConfig _config;
    
    public HttpWriter(IHttpClientFactory httpClientFactory, LoggerConfig loggerConfig)
    {
        _httpClientFactory = httpClientFactory;
        _config = loggerConfig;
    }

    public async Task<bool> SendLogsAsync(List<Log> logs)
    {
        try
        {
            var url = $"http://{_config.IpAddress}:{_config.Port}/api/v1/logs";
            var httpClient = _httpClientFactory.CreateClient("LoggerClient");

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(logs);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync(url, content);

            return response.IsSuccessStatusCode;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to send logs... {ex.Message}");
            return false;
        }
    }
}