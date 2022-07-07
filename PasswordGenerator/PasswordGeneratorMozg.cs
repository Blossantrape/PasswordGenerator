using System;

namespace PasswordGeneratorMozg
{
    class Mozg
    {
        static void Main(string[] args)
        {
            // Дописать все возможные варианты

            Console.WriteLine("Сколько символов в пароле?");
            string? inputSumSymbols = Console.ReadLine();
            int sumSymbols = Convert.ToInt32(inputSumSymbols); // Convert string to int

            Console.WriteLine("Использовать вехний и нижний, или только верхний или нижний регистр символом? \nUL/U/L");
            string? inputRegistr = Console.ReadLine();

            // Пременные для сравнения registr
            string registrUL = "UL";
            string registrul = "ul";
            string registrU = "U";
            string registru = "u";
            string registrL = "L";
            string registrl = "l";


            if ((registrUL == inputRegistr) | (registrul == inputRegistr))
            {
                //bool registerY = Convert.ToBoolean(inputRegistr); // Convert string to bool                
                Console.WriteLine("Верхний и нижний регистр");
            }
            else if ((registrU == inputRegistr) | (registru == inputRegistr) | (registrL == inputRegistr) | (registrl == inputRegistr))
            {
                Console.WriteLine("Верхний или нижний регистр?");
                if ((registrU == inputRegistr) | (registru == inputRegistr))
                {
                    Console.WriteLine("Верхний регистр");
                }
                else if ((registrL == inputRegistr) | (registrl == inputRegistr))
                {
                    Console.WriteLine("Нижний регистр");
                }
                else
                {
                    Console.WriteLine("ERROR#2"); // Ошибка
                }
            }
            else
            {
                Console.WriteLine("ERROR#1"); // Ошибка
            }


            Console.WriteLine("Использовать специальные символы? \nY/N");
            string? inputSpecSymbol = Console.ReadLine();

            // Пременные для сравнения specSymbol
            string specSymbolY = "Y";
            string specSymboly = "y";
            string specSymbolN = "N";
            string specSymboln = "n";

            if ((specSymbolY == inputSpecSymbol) | (specSymboly == inputSpecSymbol))
            {                
                Console.WriteLine("Со спецециальными символами");
            }
            else if ((specSymbolN == inputSpecSymbol) | (specSymboln == inputSpecSymbol))
            {
                Console.WriteLine("Без специальных символов");
            }
            else
            {
                Console.WriteLine("ERROR"); // Ошибка
            }

            //bool y = true;
            //bool n = false;

            // Метод регистра
            //void Register()
            //{
            //    Console.WriteLine();
            //}


            //if(y == n)
            //{
            //    Console.WriteLine("if");
            //}
            //else if(y == n)
            //{
            //    Console.WriteLine("else if");
            //}
            //else
            //{
            //    Console.WriteLine("else");
            //}
            // Сымволы для пароля
            string abc = "abcdefghijklmnopqrstuwxyz";
            string ABC = "ABCDEFGHIJKLMNOPQRSTUWXYZ";
            string numbers = "0123456789";
            string symbols = "!@#$%^&*()";

            // Тут где-то логика будет


        }
          
    }
}