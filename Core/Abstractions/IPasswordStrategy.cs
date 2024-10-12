namespace Core.Abstractions;

public interface IPasswordStrategy
{
    Task<string> GeneratePasswordAsync(int length, bool useUppercase, bool useNumbers, bool useSymbols);
}