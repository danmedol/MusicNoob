
using System.Text.Json.Serialization;
public class Stats
{
    [JsonPropertyName("listeners")]
    public string? Listeners { get; set; }

    [JsonPropertyName("playcount")]
    public string? Playcount { get; set; }
}