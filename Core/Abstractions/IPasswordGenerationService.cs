namespace Core.Abstractions;

public interface IPasswordGenerationService
{
    Task<IEnumerable<string>> GeneratePasswordsAsync(int count, int length, PasswordSpecification specification);
}