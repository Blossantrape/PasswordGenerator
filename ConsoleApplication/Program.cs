using Core;
using Core.Services;
using Core.Strategies;

namespace ConsoleApplication;

internal abstract class Program
{
    static async Task Main(string[] args)
    {
        var specification = new PasswordSpecification(useUppercase: true, useNumbers: true, useSymbols: true);
        var service = new PasswordGenerationService(new AlphanumericPasswordStrategy());

        var passwords = await service.GeneratePasswordsAsync(5, 10, specification);

        foreach (var password in passwords)
        {
            Console.WriteLine($"Сгенерированный пароль: {password}");
        }
    }
}