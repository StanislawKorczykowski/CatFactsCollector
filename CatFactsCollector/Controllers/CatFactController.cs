using CatFactsCollector.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CatFactsCollector.Controllers;

[ApiController]
[Route("catFactController")]
public class CatFactController(ICatFactService catFactService) : ControllerBase
{
    [HttpGet]
    [Route("/fact")]
    public async Task<IActionResult> GetCatFact()
    {
        var catFact = await catFactService.GetCatFactAsync();
        return Ok(catFact);
    }
}