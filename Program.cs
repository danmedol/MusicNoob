using Microsoft.Extensions.Configuration;

var config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

string apiKey = config["LastFmApiKey"] ?? "";

Console.WriteLine($"API Key carregada: {apiKey}");
