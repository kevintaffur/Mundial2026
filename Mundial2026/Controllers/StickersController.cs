using Microsoft.AspNetCore.Mvc;
using Mundial2026.Services;

namespace Mundial2026.Controllers;

[ApiController]
[Route("api/stickers")]
public class StickersController : ControllerBase
{
    private readonly StickerService _service;

    public StickersController(StickerService service)
    {
        _service = service;
    }

    [HttpGet("stats")]
    public IActionResult GetStats()
    {
        return Ok(_service.GetStats());
    }
    
    [HttpGet("missing")]
    public IActionResult GetMissing()
    {
        return Ok(
            _service.GetMissingStickers()
        );
    }
    
    [HttpGet("missing/team/{team}")]
    public IActionResult GetMissingByTeam(
        string team)
    {
        return Ok(
            _service.GetMissingByTeam(team)
        );
    }
    
    [HttpGet("completion")]
    public IActionResult GetCompletion()
    {
        return Ok(
            _service.GetCompletionPercentage());
    }
}