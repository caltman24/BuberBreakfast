using BuberBreakfast.Contracts.Breakfast;
using Microsoft.AspNetCore.Mvc;

namespace BuberBreakfast.Controllers;

[ApiController]
[Route("breakfasts")]
public class BreakfastsController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateBreakfast([FromBody] CreateBreakfastRequest request)
    {
        return Ok();
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetBreakfast([FromRoute] Guid id)
    {
        return Ok(id);
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpsertBreakfast([FromRoute] Guid id, [FromBody] UpsertBreakfastRequest request)
    {
        return Ok(id);
    }
    
    [HttpDelete("{id:guid}")]
    public IActionResult DeleteBreakfast([FromRoute] Guid id)
    {
        return Ok(id);
    }
}