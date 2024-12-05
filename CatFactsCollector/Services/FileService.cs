using CatFactsCollector.Contracts;
using CatFactsCollector.Models;

namespace CatFactsCollector.Services;

public class FileService : IFileService
{
    public  void AppendToFile(CatFact catFact)
    { 
        using var writer = new StreamWriter("catFacts.txt", true);
        writer.WriteLine(catFact.Fact);
    }
}