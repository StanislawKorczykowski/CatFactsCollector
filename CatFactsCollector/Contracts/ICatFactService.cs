using CatFactsCollector.Models;

namespace CatFactsCollector.Contracts;

public interface ICatFactService
{
    Task<CatFact?> GetCatFactAsync();
    Task<CatFactsDto?> GetCatFactsAsync();
}