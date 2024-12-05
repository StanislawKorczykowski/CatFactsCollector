using CatFactsCollector.Contracts;
using CatFactsCollector.Models;
using Newtonsoft.Json;

namespace CatFactsCollector.Services;

public class CatFactService(HttpClient httpClient, IConfiguration configuration) : ICatFactService
{
    public async Task<CatFact?> GetCatFactAsync()
    {
        var uriBuilder = new UriBuilder(configuration["BaseURL"]!);
        uriBuilder.Path += "fact";
        var response = await httpClient.GetStringAsync(uriBuilder.Uri);
        var catFact = JsonConvert.DeserializeObject<CatFact>(response);
        return catFact;
    }

    public async Task<CatFactsDto?> GetCatFactsAsync()
    {
        var uriBuilder = new UriBuilder(configuration["BaseURL"]!);
        uriBuilder.Path += "facts";
        
        var response = await httpClient.GetStringAsync(uriBuilder.Uri);
        var catFacts = JsonConvert.DeserializeObject<CatFactsDto>(response);
        return catFacts;
    }
    
}