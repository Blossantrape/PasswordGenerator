using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class PGMozg : PGMain
    {
        readonly Random randomPassword = new Random();

        public void Question1()
        {
            Console.WriteLine("Сколько паролей");

        }       

        public void Question2()
        {
            Console.WriteLine("Сколько символов в пароле");
        }        

        List<string> listQuantitySymbols = new List<string>(); // Основноый список
        List<string> ListQuantityPasswords = new List<string>(); // Для кол-ва

        public void Password()
        {
            Console.WriteLine("Сколько паролей");
            // конвертация string в int
            int QuantityPassword = int.Parse(Console.ReadLine());

            Console.WriteLine("Сколько символов в пароле");
            // конвертация string в int
            int QuantitySymbols = int.Parse(Console.ReadLine());

            string[] strings = new string[100]; // Основной массив

            int p = 0;

            for (int b = 0; b <= QuantityPassword; b++)
            {
                // Основная логика
                for (int i = 0; i < QuantitySymbols; i++)
                {
                    int value = randomPassword.Next(0, 9);
                    string valueString = Convert.ToString(value);
                    char valueS = (char)randomPassword.Next(33, 125);
                    if (valueS == '\\' || valueS == '/')
                    {
                        valueS = (char)randomPassword.Next(33, 91);
                        //Console.WriteLine($"IFPassword №:{i} -> {valueS}");
                        valueS.ToString();
                        listQuantitySymbols.Add(valueS.ToString());
                        // QuantitySymbols++;
                    }
                    else
                    {
                        //Console.WriteLine($"ELSEPassword №:{i} -> {valueS}");

                        // Копирует в список
                        listQuantitySymbols.Add(valueS.ToString());
                    }

                    // Копирует список в массив
                    listQuantitySymbols.CopyTo(strings);
                }

                p++;
                // проверка списка
                //foreach (string listSumPasswordSymbolsS in listQuantitySymbols)
                //{
                //    Console.WriteLine($"Symbol: {listSumPasswordSymbolsS}");
                //}

                //listQuantitySymbols.Clear(); // clear список

                //// добавить элементы из массива в список
                //listQuantitySymbols.AddRange(strings);

                Console.ForegroundColor = ConsoleColor.Magenta; // Цвет текста в консоли
                Console.Write($"\nPassword {p}: ");
                Console.ResetColor(); // Вернуть цвет в стандартный

                // Вывод пароля
                foreach (string listSumPasswordSymbolsS1 in listQuantitySymbols)
                {
                    int numberGarbich1 = 0;
                    int numberGarbich2 = 1;
                    int number = numberGarbich1 + numberGarbich2;


                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"{listSumPasswordSymbolsS1}");
                    Console.ResetColor();
                    ListQuantityPasswords.Add(listSumPasswordSymbolsS1);
                }

                listQuantitySymbols.Clear(); // clear список


                //Console.ForegroundColor = ConsoleColor.White; // Цвет текста в консоли
                //Console.Write("\nPasswordSSS: ");
                //Console.ResetColor(); // Вернуть цвет в стандартный

                //// Вывод пароля
                //foreach (string listSumPasswordSymbolsS2 in ListQuantityPasswords)
                //{
                //    Console.ForegroundColor = ConsoleColor.Cyan;
                //    Console.Write(listSumPasswordSymbolsS2);
                //    Console.ResetColor();
                //}
            }
        }
    }
}
