namespace PasswordGenerator
{
    class PGMain
    {
        protected readonly Random RandomPassword = new Random();

        // Список символов
        protected readonly List<string> ListQuantitySymbols = new List<string>(); 

        /// <summary>
        /// Optional Password
        /// </summary>
        private static void Setings()
        {
            PGMozg Full = new PGMozg();
            PGCondicions Optional = new PGCondicions();

            // Опцональность пароля
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Enter the optional password or click Enter to get help");
            Console.ResetColor();
            string? setingsPassword = Console.ReadLine();
            Console.Clear();

            switch (setingsPassword)
            {
                case "Full":
                    Full.FullPassword();
                    break;
                case "NLUL":
                    Optional.NumberLetterUL();
                    break;
                case "NLU":
                    Optional.NumberLetterU();
                    break;
                case "NLL":
                    Optional.NumberLetterL();
                    break;
                case "LUL":
                    Optional.LetterUL();
                    break;
                case "LU":
                    Optional.LetterU();
                    break;
                case "LL":
                    Optional.LetterL();
                    break;
                case "N":
                    Optional.Number();
                    break;
                case "SNLU":
                    Optional.SpecialNumberLetterU();
                    break;
                case "SNLL":
                    Optional.SpecialNumberLetterL();
                    break;
                case "SN":
                    Optional.SpecialNumber();
                    break;
                case "SLU":
                    Optional.SpecialLetterU();
                    break;
                case "SLL":                   
                    Optional.SpecialLetterL();
                    break;
                case "S" :
                    Optional.Special();
                    break;
                default:
                    Full.Help();
                    break;
            }
        }      

        public static void Main(string[] args)
        {
            PGMain.Setings();
            
            // Решает баг ниже
            Console.WriteLine("\n");
            // Из-за него бег с пропаданием символа "P" в Password (у последнего пароля) на некоторых консолях
            Console.ReadKey();
        }
    }
}
