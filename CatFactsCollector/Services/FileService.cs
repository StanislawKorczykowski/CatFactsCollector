using CatFactsCollector.Contracts;
using CatFactsCollector.Models;

namespace CatFactsCollector.Services;

public class FileService(IConfiguration configuration) : IFileService
{
    public void AppendToFile(CatFact catFact)
    {
        using var writer = new StreamWriter(configuration["FilePath"]!, true);
        writer.WriteLine(catFact.Fact);
    }
    public void AppendToFile(CatFactsDto catFactsDto)
    {
        using var writer = new StreamWriter(configuration["FilePath"]!, true);
        foreach (var catFact in catFactsDto.Facts!)
        {
            writer.WriteLine(catFact.Fact);
        }
    }
}