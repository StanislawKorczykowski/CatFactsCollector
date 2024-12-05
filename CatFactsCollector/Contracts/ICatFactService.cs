using CatFactsCollector.Models;

namespace CatFactsCollector.Contracts;

public interface ICatFactService
{
    Task<CatFact?> GetCatFactAsync(int? length);
    Task<CatFactsDto?> GetCatFactsAsync(int? length, int? limit);
}