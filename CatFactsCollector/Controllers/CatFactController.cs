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
}