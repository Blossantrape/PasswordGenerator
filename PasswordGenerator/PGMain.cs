using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class PGMain
    {

        readonly public Random randomPassword = new Random();

        public List<string> ListQuantitySymbols = new List<string>(); // Список символов
        public List<string> ListQuantityPasswords = new List<string>(); // Список паролей

        public static void Setings()
        {
            PGMozg Full = new PGMozg();
            PGCondicions Test = new PGCondicions();

            // Опцональность пароля
            Console.WriteLine("Опцональность пароля");
            string? SetingsPassword = Console.ReadLine();

            switch (SetingsPassword)
            {
                case "Full":
                    Full.FullPassword();
                    break;
                case "0":
                    // Переделать
                    Test.hz();
                    break;
                case "1":
                    Test.NumberLetterLU();
                    break;
                case "4":
                    // Действие
                    break;

            }
        }      

        public static void Main(string[] args)
        {
            PGMozg GenPassword = new PGMozg();
            PGMain.Setings();

            // Решает баг ниже
            Console.WriteLine("\n");

            // Из-за него бег с пропаданием символа "P" в Password (у последнего пароля) в консоли
            Console.ReadKey();
        }
    }
}
