using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Json;

namespace HealthcareMonitoring.Server.Controllers;

//[Authorize]
[ApiController]
[Route("api/[controller]")]
public class OpenAIController : ControllerBase
{
    private IAzureOpenAIService _openAIService;

    public OpenAIController(IAzureOpenAIService service)
    {
        _openAIService = service;
    }

    [HttpPost]
    public async Task<string> Post([FromBody] string val)
    {
        var result = new StringBuilder();
        await _openAIService.CreateNewTopic();
        var content = """
            heartRate = 180 rhythm = Normal P_wave = Normal PR_Interval = 42.56 QRS_Complex = 73.89 QT_Interval = 64.25 ST_Interval = 38.12 T_Wave = Normal hb = 11.85 hct = 37.24 rbc = 4.68 wbc = 12.59 plt = 234.56 lumarSpine = 6.32 totalHip = 45.78 tscoreL = 3.14 tscoreH = 4.29 fvc = 3.78 fev1 = 4.03 fev1_fvc_ratio = 0.85 pef = 8.91 tv = 0.54 MedicalType = Type A Based on this medical report, give me the possible of illiness may arise from the data above This is just an example of medical report give me the respond
            """;
        await foreach (var chatMessage in _openAIService.GetChatCompletionsStreamingAsync(content))
        {
            result.Append(chatMessage.Content);
        }
        return result.ToString();
    }
}