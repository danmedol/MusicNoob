using System.Text.Json.Serialization;

public class Artist
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("stats")]
    public Stats? Stats { get; set; }

    [JsonPropertyName("similar")]
    public Similar? Similar { get; set; }

    [JsonPropertyName("bio")]
    public Bio? Bio { get; set; }

}