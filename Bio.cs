
using System.Text.Json.Serialization;
public class Bio
{
    [JsonPropertyName("summary")]
    public string Summary{get; set;}
}