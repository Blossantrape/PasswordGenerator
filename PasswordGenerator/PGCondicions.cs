using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class PGCondicions : PGMain
    {
        public void hz()
        {
            Console.WriteLine("Сколько паролей");
            // конвертация string в int
            int QuantityPassword = int.Parse(Console.ReadLine());

            Console.WriteLine("Сколько символов в пароле");
            // конвертация string в int
            int QuantitySymbols = int.Parse(Console.ReadLine());

            string[] strings = new string[QuantitySymbols]; // Основной массив

            // Переменная для номера пароля
            int p = 0;

            // Цикл количества паролей
            for (int b = 1; b <= QuantityPassword; b++)
            {
                // Основная логика генерации пароля (FullPassword)
                for (int i = 0; i < QuantitySymbols; i++)
                {
                    // Цифры от 1-9
                    int value = randomPassword.Next(0, 9);
                    string valueString = Convert.ToString(value);

                    // Рандомная генерация символов по таблице ASCII в диапазоне 33 - 125
                    char valueS = (char)randomPassword.Next(33, 125);

                    // Логика замены генерируемых символов из valueS "\\" и "/" на числа таблицы ASCII в диапазоне 33 - 125  
                    if (valueS == '\\' || valueS == '/')
                    {
                        valueS = (char)randomPassword.Next(33, 91);

                        // Добавление символов в список ListQuantitySymbols с конвертацией
                        ListQuantitySymbols.Add(valueS.ToString());
                    }
                    // Если в генерации не попались символы "\\" и "/"
                    else
                    {
                        // Добавление символов в список ListQuantitySymbols с конвертацией
                        ListQuantitySymbols.Add(valueS.ToString());
                    }
                }

                // Переменная для номера пароля
                p++;

                Console.ForegroundColor = ConsoleColor.Magenta; // Изменяет цвет текста в консоли на Magenta
                Console.Write($"\nPassword {p}: ");
                Console.ResetColor(); // Изменяет цвет текста в коноли на стандартный

                // Вывод пароля и перебор
                foreach (string listSumPasswordSymbolsS1 in ListQuantitySymbols)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow; // Изменяет цвет текста в консоли на Yellow
                    Console.Write($"{listSumPasswordSymbolsS1}");
                    Console.ResetColor(); // Изменяет цвет текста в коноли на стандартный
                }

                // Очистка списка
                ListQuantitySymbols.Clear();
            }
        }

        public void NumberLetterLU()
        {
            Console.WriteLine("Сколько паролей");
            // конвертация string в int
            int QuantityPassword = int.Parse(Console.ReadLine());

            Console.WriteLine("Сколько символов в пароле");
            // конвертация string в int
            int QuantitySymbols = int.Parse(Console.ReadLine());

            string[] strings = new string[QuantitySymbols]; // Основной массив

            // Переменная для номера пароля
            int p = 0;

            // Цикл количества паролей
            for (int b = 1; b <= QuantityPassword; b++)
            {
                // Основная логика генерации пароля (FullPassword)
                for (int i = 0; i < QuantitySymbols; i++)
                {
                    // Рандомная генерация символов по таблице ASCII в диапазоне 33 - 125
                    char valueS = (char)randomPassword.Next(48, 122);

                    // Для проверки символа "'"
                    bool check = Convert.ToChar(valueS) == Convert.ToChar(96);

                    // Логика замены генерируемых символов из valueS "\\" и "/" на числа таблицы ASCII в диапазоне 33 - 125  
                    if (valueS == '\\' || valueS == '/')
                    {
                        valueS = (char)randomPassword.Next(97, 122);
                        //Console.WriteLine($"IFPassword №:{i} -> {valueS}"); // Проверка
                        valueS.ToString();

                        // Добавление символов в список ListQuantitySymbols с конвертацией
                        ListQuantitySymbols.Add(valueS.ToString());
                    }
                    else if (valueS == ':' || valueS == ';' || valueS == '<' || valueS == '=' || valueS == '>' || valueS == '?'  || valueS == '@')
                    {
                        valueS = (char)randomPassword.Next(48, 57);
                        valueS.ToString();
                        ListQuantitySymbols.Add(valueS.ToString());
                    }
                    else if (valueS == '[' || valueS == ']' || valueS == '^' || valueS == '_')
                    {
                        valueS = (char)randomPassword.Next(65, 90);
                        valueS.ToString();
                        ListQuantitySymbols.Add(valueS.ToString());
                    }
                    else if (check == true)
                    {
                        valueS = (char)randomPassword.Next(65, 90);
                        valueS.ToString();
                        ListQuantitySymbols.Add(valueS.ToString());
                    }
                    else
                    {
                        // Добавление символов в список ListQuantitySymbols с конвертацией
                        ListQuantitySymbols.Add(valueS.ToString());
                    }

                    // Копирует список в массив strings
                    ListQuantitySymbols.CopyTo(strings);
                }

                // Переменная для номера пароля
                p++;

                Console.ForegroundColor = ConsoleColor.Magenta; // Изменяет цвет текста в консоли на Magenta
                Console.Write($"\nPasswordTest {p}: ");
                Console.ResetColor(); // Изменяет цвет текста в коноли на стандартный

                // Вывод пароля и перебор
                foreach (string listSumPasswordSymbolsS1 in ListQuantitySymbols)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow; // Изменяет цвет текста в консоли на Yellow
                    Console.Write($"{listSumPasswordSymbolsS1}");
                    Console.ResetColor(); // Изменяет цвет текста в коноли на стандартный
                }

                // Очистка списка
                ListQuantitySymbols.Clear();
            }
        }
    }
}
