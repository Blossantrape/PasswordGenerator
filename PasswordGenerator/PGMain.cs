namespace PasswordGenerator
{
    class PGMain
    {
        readonly public Random RandomPassword = new Random();

        public List<string> ListQuantitySymbols = new List<string>(); // Список символов
        public List<string> ListQuantityPasswords = new List<string>(); // Список паролей

        private static void Setings()
        {
            PGMozg Full = new PGMozg();
            PGCondicions Optional = new PGCondicions();

            // Опцональность пароля
            Console.WriteLine("Опцональность пароля");
            string? setingsPassword = Console.ReadLine();

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

            }
        }      

        public static void Main(string[] args)
        {
            PGMain.Setings();

            // Решает баг ниже
            Console.WriteLine("\n");

            // Из-за него бег с пропаданием символа "P" в Password (у последнего пароля) в консоли
            Console.ReadKey();
        }
    }
}
