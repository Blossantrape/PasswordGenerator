using Core;
using Core.Strategies;
using FileGenerator;

class Program
{
    static async Task Main(string[] args)
    {
        var generator = new PasswordBatchGenerator(new AlphanumericPasswordStrategy());

        Console.Write("Введите количество паролей для генерации: ");
        int count = int.Parse(Console.ReadLine());

        Console.Write("Введите длину паролей: ");
        int length = int.Parse(Console.ReadLine());

        var passwords = await generator.GenerateMultiplePasswordsAsync(count, length, true, true, true);
        FileWriter.WritePasswordsToFile("passwords.txt", passwords);

        Console.WriteLine("Пароли сохранены в файл passwords.txt");
    }
}
