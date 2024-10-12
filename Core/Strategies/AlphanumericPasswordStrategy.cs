using Core.Abstractions;

namespace Core.Strategies;

public class AlphanumericPasswordStrategy : IPasswordStrategy
{
    public async Task<string> GeneratePasswordAsync(int length, bool useUppercase, bool useNumbers, bool useSymbols)
    {
        const string lowercase = "abcdefghijklmnopqrstuvwxyz";
        const string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string numbers = "1234567890";
        const string symbols = "!@#$%^&*()_-+={}[]|:;<>,.?/";

        string validChars = lowercase;
        
        if (useUppercase) validChars += uppercase;
        if (useNumbers) validChars += numbers;
        if (useSymbols) validChars += symbols;

        return await SecurePasswordHelper.GenerateSecurePasswordAsync(length, validChars);
    }
}
