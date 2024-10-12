using Core;
using Core.Abstractions;
using Core.Strategies;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controller;

[ApiController]
[Route("api/[controller]")]
public class PasswordController : ControllerBase
{
    [HttpGet("generate")]
    public async Task<IActionResult> Generate(string strategyType, int length, bool useUppercase = true, bool useNumbers = true, bool useSymbols = true)
    {
        IPasswordStrategy strategy = strategyType.ToLower() switch
        {
            "numeric" => new NumericOnlyPasswordStrategy(),
            "symbols" => new SymbolsOnlyPasswordStrategy(),
            _ => new AlphanumericPasswordStrategy()
        };

        var generator = new PasswordGenerator();
        generator.SetStrategy(strategy);
        string password = await generator.GenerateAsync(length, useUppercase, useNumbers, useSymbols);
        return Ok(password);
    }

    [HttpGet("generate-batch")]
    public async Task<IActionResult> GenerateBatch(int count, int length, bool useUppercase = true, bool useNumbers = true, bool useSymbols = true)
    {
        var batchGenerator = new PasswordBatchGenerator(new AlphanumericPasswordStrategy());
        var passwords = await batchGenerator.GenerateMultiplePasswordsAsync(count, length, useUppercase, useNumbers, useSymbols);
        return Ok(passwords);
    }
}
