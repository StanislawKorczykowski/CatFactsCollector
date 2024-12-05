using CatFactsCollector.Models;

namespace CatFactsCollector.Contracts;

public interface IFileService
{
    void AppendToFile(CatFact fact);
    void AppendToFile(CatFactsDto facts);

}