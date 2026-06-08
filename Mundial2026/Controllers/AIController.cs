using Microsoft.AspNetCore.Mvc;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.OpenAI;

namespace Mundial2026.Controllers;

[ApiController]
[Route("api/ai")]
public class AIController : ControllerBase
{
    private readonly Kernel _kernel;

    public AIController(Kernel kernel)
    {
        _kernel = kernel;
    }

    [HttpPost("chat")]
    public async Task<IActionResult> Chat([FromBody] string message)
    {
        var chat = _kernel.GetRequiredService<IChatCompletionService>();

        var executionSettings = new OpenAIPromptExecutionSettings
        {
            FunctionChoiceBehavior = FunctionChoiceBehavior.Auto()
        };

        var history = new ChatHistory();
        history.AddSystemMessage("Eres un asistente del álbum del mundial. Usa herramientas cuando sea necesario.");
        history.AddUserMessage(message);

        var result = await chat.GetChatMessageContentAsync(
            history,
            executionSettings,
            _kernel
        );

        return Ok(result.Content);
    }
}