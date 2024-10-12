using Core.Abstractions;

namespace Core.Strategies;

public class SymbolsOnlyPasswordStrategy : IPasswordStrategy
{
    public async Task<string> GeneratePasswordAsync(int length, bool useUppercase, bool useNumbers, bool useSymbols)
    {
        const string symbols = "!@#$%^&*()_-+={}[]|:;<>,.?/";
        return await SecurePasswordHelper.GenerateSecurePasswordAsync(length, symbols);
    }
}
