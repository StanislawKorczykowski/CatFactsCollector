using CatFactsCollector.Contracts;
using CatFactsCollector.Models;

namespace CatFactsCollector.Services;

public class FileService(IConfiguration configuration) : IFileService
{
    public  void AppendToFile(CatFact catFact)
    { 
        using var writer = new StreamWriter(configuration["FilePath"]!, true);
        writer.WriteLine(catFact.Fact);
    }
}