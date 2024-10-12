using Core.Abstractions;

namespace Core.Strategies;

public class NumericOnlyPasswordStrategy : IPasswordStrategy
{
    public async Task<string> GeneratePasswordAsync(int length, bool useUppercase, bool useNumbers, bool useSymbols)
    {
        const string numbers = "1234567890";
        return await SecurePasswordHelper.GenerateSecurePasswordAsync(length, numbers);
    }
}
