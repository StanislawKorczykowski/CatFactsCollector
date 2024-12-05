using CatFactsCollector.Contracts;
using CatFactsCollector.Models;
using Newtonsoft.Json;

namespace CatFactsCollector.Services;

public class CatFactService(HttpClient httpClient) : ICatFactService
{
    public async Task<CatFact?> GetCatFactAsync()
    {
        var response = await httpClient.GetStringAsync("https://catfact.ninja/fact");
        var catFact = JsonConvert.DeserializeObject<CatFact>(response);
        return catFact;
    }
    
}