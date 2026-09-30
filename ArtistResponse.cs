using System.Text.Json.Serialization;

public class ArtistResponse
{
    [JsonPropertyName("artist")]
    public Artist? Artist{get; set;}
}
