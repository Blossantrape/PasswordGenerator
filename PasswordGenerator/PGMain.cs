using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class PGMain
    {
        //public int QuentityPass = 5;
        //public int QuentitySymbolsPass = 4;

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
            Console.WriteLine("Настройки пароля");
            // настройки пароля
            string? SetingsPassword = Console.ReadLine();

            switch (SetingsPassword)
            {
                case "1":
                    Console.WriteLine("Успешно");
                    break;
                case "2":
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

            //GenPassword.Question1();
            //GenPassword.Question2();
            GenPassword.Password();
        }
    }
}
