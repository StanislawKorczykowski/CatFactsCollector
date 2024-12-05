using CatFactsCollector.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CatFactsCollector.Controllers;

[ApiController]
[Route("catFactController")]
public class CatFactController(ICatFactService catFactService, IFileService fileService) : ControllerBase
{
    [HttpGet]
    [Route("/fact")]
    public async Task<IActionResult> GetCatFact()
    {
        var catFact = await catFactService.GetCatFactAsync();
        if (catFact == null) return NotFound();
        fileService.AppendToFile(catFact);
        return Ok(catFact);
    }

    [HttpGet]
    [Route("/facts")]
    public async Task<IActionResult> GetCatFacts()
    {
        var catFacts = await catFactService.GetCatFactsAsync();
        if (catFacts == null) return NotFound();
        fileService.AppendToFile(catFacts);
        return Ok(catFacts);
    }
}