using Core;
using Core.Strategies;

namespace ConsoleApplication;

internal abstract class Program
{
    static async Task Main(string[] args)
    {
        var generator = new PasswordGenerator();
        generator.SetStrategy(new AlphanumericPasswordStrategy());

        Console.Write("Введите длину пароля: ");
        int length = int.Parse(Console.ReadLine());

        Console.Write("Использовать заглавные буквы? (y/n): ");
        bool useUppercase = Console.ReadLine().ToLower() == "y";

        Console.Write("Использовать цифры? (y/n): ");
        bool useNumbers = Console.ReadLine().ToLower() == "y";

        Console.Write("Использовать символы? (y/n): ");
        bool useSymbols = Console.ReadLine().ToLower() == "y";

        string password = await generator.GenerateAsync(length, useUppercase, useNumbers, useSymbols);
        Console.WriteLine($"Сгенерированный пароль: {password}");
    }
}