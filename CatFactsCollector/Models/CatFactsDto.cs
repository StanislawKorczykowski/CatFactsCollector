using Newtonsoft.Json;

namespace CatFactsCollector.Models;

public class CatFactsDto
{
    [JsonProperty("data")] public List<CatFact>? Facts { get; set; }
}