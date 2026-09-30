using System.Text.Json.Serialization;

public class Similar
{
    [JsonPropertyName("artist")]
    public List<SimilarArtist>? Artist{get; set;}
}