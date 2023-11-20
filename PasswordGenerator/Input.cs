using System.Diagnostics.CodeAnalysis;

namespace PasswordGenerator
{
    class Input
    {
        protected readonly Random RandomPassword = new Random();

        // Список символов
        protected readonly List<string> ListQuantitySymbols = new List<string>(); 

        /// <summary>
        /// Optional Password
        /// </summary>
        [SuppressMessage("ReSharper.DPA", "DPA0000: DPA issues")]
        private static void Settings()
        {
            HelpC full = new HelpC();
            Modes optional = new Modes();

            // Опцональность пароля
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Enter the optional password or click 'Enter' to get help");
            Console.ResetColor();
            string? settingsPassword = Console.ReadLine();
            Console.Clear();

            switch (settingsPassword)
            {
                case "1":
                    optional.FullPassword();
                    break;
                case "2":
                    optional.NumberLetterUL();
                    break;
                case "3":
                    optional.NumberLetterU();
                    break;
                case "4":
                    optional.NumberLetterL();
                    break;
                case "5":
                    optional.LetterUL();
                    break;
                case "6":
                    optional.LetterU();
                    break;
                case "7":
                    optional.LetterL();
                    break;
                case "8":
                    optional.Number();
                    break;
                case "9":
                    optional.SpecialNumberLetterU();
                    break;
                case "10":
                    optional.SpecialNumberLetterL();
                    break;
                case "11":
                    optional.SpecialNumber();
                    break;
                case "12":
                    optional.SpecialLetterU();
                    break;
                case "13":                   
                    optional.SpecialLetterL();
                    break;
                case "14" :
                    optional.Special();
                    break;
                default:
                    full.Help();
                    break;
            }
        }      

        public static void Main(string[] args)
        {
            Input.Settings();
            
            // Решает баг ниже
            Console.WriteLine("\n");
            // Из-за него баг с пропаданием символа "P" в "Password" (у последнего пароля) на некоторых консолях
            Console.ReadKey();
        }
    }
}
