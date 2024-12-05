using CatFactsCollector.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CatFactsCollector.Controllers;

[ApiController]
[Route("catFactController")]
public class CatFactController(ICatFactService catFactService, IFileService fileService) : ControllerBase
{
    [HttpGet]
    [Route("/fact")]
    public async Task<IActionResult> GetCatFact(int? length)
    {
        var catFact = await catFactService.GetCatFactAsync(length);
        if (catFact == null) return NotFound();
        fileService.AppendToFile(catFact);
        return Ok(catFact);
    }

    [HttpGet]
    [Route("/facts")]
    public async Task<IActionResult> GetCatFacts(int? length, int limit)
    {
        var catFacts = await catFactService.GetCatFactsAsync(length, limit);
        if (catFacts == null) return NotFound();
        fileService.AppendToFile(catFacts);
        return Ok(catFacts);
    }
}