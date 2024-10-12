using Core.Abstractions;

namespace Core;

public class PasswordBatchGenerator
{
    private readonly IPasswordStrategy _strategy;
    public PasswordBatchGenerator(IPasswordStrategy strategy)
    {
        _strategy = strategy;
    }

    public async Task<IEnumerable<string>> GenerateMultiplePasswordsAsync(int count, int length, bool useUppercase, bool useNumbers, bool useSymbols)
    {
        var tasks = new List<Task<string>>();

        Parallel.For(0, count, (i) =>
        {
            tasks.Add(_strategy.GeneratePasswordAsync(length, useUppercase, useNumbers, useSymbols));
        });

        return await Task.WhenAll(tasks);
    }
}