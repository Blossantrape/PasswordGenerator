using Core.Abstractions;

namespace Core.Services;

public class PasswordGenerationService : IPasswordGenerationService
{
    private IPasswordStrategy _strategy;

    public PasswordGenerationService(IPasswordStrategy strategy)
    {
        _strategy = strategy;
    }

    public async Task<IEnumerable<string>> GeneratePasswordsAsync(int count, int length, PasswordSpecification specification)
    {
        var tasks = new List<Task<string>>();
        for (int i = 0; i < count; i++)
        {
            tasks.Add(_strategy.GeneratePasswordAsync(length, specification.UseUppercase, specification.UseNumbers, specification.UseSymbols));
        }

        return await Task.WhenAll(tasks);
    }
}