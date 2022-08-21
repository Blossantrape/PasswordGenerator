using System;
using System.Collections.Generic;
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

        // Дописать все возможные варианты

        // Пременные для сравнения registr
        string registrUL = "UL";
        string registrul = "ul";
        string registrU = "U";
        string registru = "u";
        string registrL = "L";
        string registrl = "l";

        // Переменные для сравнния number
        string numberY = "Y";
        string numbery = "y";
        string numberN = "N";
        string numbern = "n";

        // Пременные для сравнения specSymbol
        string specSymbolY = "Y";
        string specSymboly = "y";
        string specSymbolN = "N";
        string specSymboln = "n";

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
                    //Console.WriteLine("Успешно");
                    break;
                case "2":
                    Test.TestPassword();
                    // Действие
                    break;
                case "3":
                    // Действие
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

            // Из-за него бег с пропаданием символа "P" в Password (у последнего пароля) в консоли
            Console.ReadKey();
        }
    }
}
