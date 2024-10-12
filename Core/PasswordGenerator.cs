using Core.Abstractions;

namespace Core;

public class PasswordGenerator
{
    private IPasswordStrategy _strategy;
    
    public void SetStrategy(IPasswordStrategy strategy)
    {
        _strategy = strategy;
    }

    public async Task<string> GenerateAsync(int length, bool useUppercase = true, bool useNumbers = true, bool useSymbols = true)
    {
        if (_strategy == null)
            throw new InvalidOperationException("Не установлена стратегия генерации пароля.");

        return await _strategy.GeneratePasswordAsync(length, useUppercase, useNumbers, useSymbols);
    }
}