using System;

namespace PasswordGeneratorMozg
{
    class Mozg
    {
        static void Main(string[] args)
        {
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

            // Символы для пароля
            string abc = "abcdefghijklmnopqrstuwxyz";
            string ABC = "ABCDEFGHIJKLMNOPQRSTUWXYZ";
            string numbers = "0123456789";
            string symbols = "!@#$%^&*()";

            // Пременные для сравнения specSymbol
            string specSymbolY = "Y";
            string specSymboly = "y";
            string specSymbolN = "N";
            string specSymboln = "n";

            Console.WriteLine("Сколько символов в пароле?");
            string? inputSumSymbols = Console.ReadLine();
            int sumSymbols = Convert.ToInt32(inputSumSymbols); // Convert string to int

            Console.WriteLine("Использовать вехний и нижний, или только верхний или нижний регистр символом? \nUL/U/L");
            string? inputRegistr = Console.ReadLine();

            if ((registrUL == inputRegistr) | (registrul == inputRegistr))
            {
                //bool registerY = Convert.ToBoolean(inputRegistr); // Convert string to bool
                Console.WriteLine("Использовать цифры? \nY/N");
                string? inputNumber = Console.ReadLine();

                if((numberY == inputNumber) | (numbery == inputNumber))
                {
                    Console.WriteLine("Использовать цифры");
                    Console.WriteLine("Использовать специальные символы? \nY/N");
                    string? inputSpecSymbol = Console.ReadLine();

                    if ((specSymbolY == inputSpecSymbol) | (specSymboly == inputSpecSymbol))
                    {
                        Console.WriteLine("Со спецециальными символами");
                        Console.WriteLine("Верхний и нижний регистр");
                        string passwordULNS = string.Concat(abc, ABC, numbers, symbols);


                        Console.WriteLine(passwordULNS);
                    }
                    else if ((specSymbolN == inputSpecSymbol) | (specSymboln == inputSpecSymbol))
                    {
                        Console.WriteLine("Без специальных символов");
                    }
                    else
                    {
                        Console.WriteLine("ERROR"); // Ошибка
                    }
                }
                else if((numberN == inputNumber) | (numbern == inputNumber))
                {
                    Console.WriteLine("Не использовать цифры");
                }
                else
                {
                    Console.WriteLine("ERROR"); // Ошибка
                }

                

            }
            else if ((registrU == inputRegistr) | (registru == inputRegistr) | (registrL == inputRegistr) | (registrl == inputRegistr))
            {
                Console.WriteLine("Верхний или нижний регистр?");
                if ((registrU == inputRegistr) | (registru == inputRegistr))
                {
                    Console.WriteLine("Верхний регистр");

                    Console.WriteLine("Использовать специальные символы? \nY/N");
                    string? inputSpecSymbol = Console.ReadLine();

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
                }
                else if ((registrL == inputRegistr) | (registrl == inputRegistr))
                {
                    Console.WriteLine("Нижний регистр");

                    Console.WriteLine("Использовать специальные символы? \nY/N");
                    string? inputSpecSymbol = Console.ReadLine();

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


            
            
            

            // Тут где-то логика будет
            //if(UL == 1)
            //{
            //    string passwordULNS = string.Concat(abc, ABC, numbers, symbols);
            //    Console.WriteLine("logIf");
            //    Console.WriteLine(passwordULNS);
            //}
            //else if()
            //{
            //    Console.WriteLine("logElseIf");
            //}
            //else
            //{
            //    Console.WriteLine("logElse");
            //}

        }
          
    }
}