using System.Text.RegularExpressions;

namespace PasswordGenerator
{
    class PGCondicions : PGMain
    {
        /// <summary>
        /// Using symbols on generate password: Number, Letter Upper register.
        /// </summary>
        public void NumberLetterU()
        {
            Console.WriteLine("Сколько паролей");
            // конвертация string в int
            int QuantityPassword = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("Сколько символов в пароле");
            // конвертация string в int
            int QuantitySymbols = int.Parse(Console.ReadLine() ?? string.Empty);

            // Переменная для номера пароля
            int p = 0;

            // Цикл количества паролей
            for (int b = 1; b <= QuantityPassword; b++)
            {
                // Основная логика генерации пароля (FullPassword)
                for (int i = 0; i < QuantitySymbols; i++)
                {
                    // Рандомная генерация символов по таблице ASCII в диапазоне Next
                    char valueS = (char)RandomPassword.Next(48, 90);

                    // Для проверки символа "'"
                    bool check = Convert.ToChar(valueS) == Convert.ToChar(96);

                    // Логика замены генерируемых символов из valueS "\\" и "/" на числа таблицы ASCII в диапазоне Next 
                    if (valueS == '\\' || valueS == '/')
                    {
                        valueS = (char)RandomPassword.Next(48, 57);
                        //Console.WriteLine($"IFPassword №:{i} -> {valueS}"); // Проверка

                        // Добавление символов в список ListQuantitySymbols с конвертацией
                        ListQuantitySymbols.Add(valueS.ToString());
                    }
                    else if (valueS == ':' || valueS == ';' || valueS == '<' || valueS == '=' || valueS == '>' || valueS == '?'  || valueS == '@')
                    {
                        valueS = (char)RandomPassword.Next(48, 57);
                        ListQuantitySymbols.Add(valueS.ToString());
                    }
                    else if (valueS == '[' || valueS == ']' || valueS == '^' || valueS == '_')
                    {
                        valueS = (char)RandomPassword.Next(65, 90);
                        ListQuantitySymbols.Add(valueS.ToString());
                    }
                    else if (check)
                    {
                        valueS = (char)RandomPassword.Next(65, 90);
                        ListQuantitySymbols.Add(valueS.ToString());
                    }
                    else
                    {
                        // Добавление символов в список ListQuantitySymbols с конвертацией
                        ListQuantitySymbols.Add(valueS.ToString());
                    }
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
        /// <summary>
        /// Using symbols on generate password: Number, Letter upper and lower register.
        /// </summary>
        public void NumberLetterUL()
        {
            Console.WriteLine("Сколько паролей");
            // конвертация string в int
            int QuantityPassword = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("Сколько символов в пароле");
            // конвертация string в int
            int QuantitySymbols = int.Parse(Console.ReadLine() ?? string.Empty);

            // Переменная для номера пароля
            int p = 0;

            // Цикл количества паролей
            for (int b = 1; b <= QuantityPassword; b++)
            {
                // Основная логика генерации пароля (FullPassword)
                for (int i = 0; i < QuantitySymbols; i++)
                {
                    // Рандомная генерация символов по таблице ASCII в диапазоне 33 - 125
                    char valueS = (char)RandomPassword.Next(48, 122);

                    // Для проверки символа "'"
                    bool check = Convert.ToChar(valueS) == Convert.ToChar(96);

                    // Логика замены генерируемых символов из valueS "\\" и "/" на числа таблицы ASCII в диапазоне 33 - 125  
                    if (valueS == '\\' || valueS == '/')
                    {
                        valueS = (char)RandomPassword.Next(97, 122);
                        //Console.WriteLine($"IFPassword №:{i} -> {valueS}"); // Проверка

                        // Добавление символов в список ListQuantitySymbols с конвертацией
                        ListQuantitySymbols.Add(valueS.ToString());
                    }
                    else if (valueS == ':' || valueS == ';' || valueS == '<' || valueS == '=' || valueS == '>' || valueS == '?'  || valueS == '@')
                    {
                        valueS = (char)RandomPassword.Next(48, 57);
                        ListQuantitySymbols.Add(valueS.ToString());
                    }
                    else if (valueS == '[' || valueS == ']' || valueS == '^' || valueS == '_')
                    {
                        valueS = (char)RandomPassword.Next(65, 90);
                        ListQuantitySymbols.Add(valueS.ToString());
                    }
                    else if (check)
                    {
                        valueS = (char)RandomPassword.Next(65, 90);
                        ListQuantitySymbols.Add(valueS.ToString());
                    }
                    else
                    {
                        // Добавление символов в список ListQuantitySymbols с конвертацией
                        ListQuantitySymbols.Add(valueS.ToString());
                    }
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
        /// <summary>
        /// Using symbols on generate password: Number, Letter lower.
        /// </summary>
        public void NumberLetterL()
        {
            Console.WriteLine("Сколько паролей");
            // конвертация string в int
            int QuantityPassword = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("Сколько символов в пароле");
            // конвертация string в int
            int QuantitySymbols = int.Parse(Console.ReadLine() ?? string.Empty);

            // Переменная для номера пароля
            int p = 0;

            // Цикл количества паролей
            for (int b = 1; b <= QuantityPassword; b++)
            {
                // Основная логика генерации пароля (FullPassword)
                for (int i = 0; i < QuantitySymbols; i++)
                {
                    // Рандомная генерация символов по таблице ASCII в диапазоне Next
                    char valueS = (char)RandomPassword.Next(91, 125);

                    // Для проверки символа "'"
                    bool check = Convert.ToChar(valueS) == Convert.ToChar(96);

                    // Логика замены генерируемых символов из valueS "\\" и "/" на числа таблицы ASCII в диапазоне Next  
                    if (valueS == '\\' || valueS == '/')
                    {
                        valueS = (char)RandomPassword.Next(97, 122);
                        // Добавление символов в список ListQuantitySymbols с конвертацией
                        ListQuantitySymbols.Add(valueS.ToString());
                    }
                    else if (valueS == ':' || valueS == ';' || valueS == '<' || valueS == '=' || valueS == '>' || valueS == '?'  || valueS == '|')
                    {
                        valueS = (char)RandomPassword.Next(48, 57);
                        ListQuantitySymbols.Add(valueS.ToString());
                    }
                    else if (valueS == '[' || valueS == ']' || valueS == '^' || valueS == '_'  || valueS == '@'  || valueS == '{'  || valueS == '}')
                    {
                        valueS = (char)RandomPassword.Next(48, 57);
                        ListQuantitySymbols.Add(valueS.ToString());
                    }
                    else if (check)
                    {
                        valueS = (char)RandomPassword.Next(97, 122);
                        ListQuantitySymbols.Add(valueS.ToString());
                    }
                    else
                    {
                        // Добавление символов в список ListQuantitySymbols с конвертацией
                        ListQuantitySymbols.Add(valueS.ToString());
                    }
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
        /// <summary>
        /// Using symbols on generate password: Letter upper and lower register.
        /// </summary>
        public void LetterUL()
        {
            Console.WriteLine("Сколько паролей");
            // конвертация string в int
            int QuantityPassword = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("Сколько символов в пароле");
            // конвертация string в int
            int QuantitySymbols = int.Parse(Console.ReadLine() ?? string.Empty);

            // Переменная для номера пароля
            int p = 0;

            // Цикл количества паролей
            for (int b = 1; b <= QuantityPassword; b++)
            {
                // Основная логика генерации пароля (FullPassword)
                for (int i = 0; i < QuantitySymbols; i++)
                {
                    // Рандомная генерация символов по таблице ASCII в диапазоне Next
                    char valueS = (char)RandomPassword.Next(65, 122);

                    // Для проверки символа "'"
                    bool check = Convert.ToChar(valueS) == Convert.ToChar(96);

                    // Логика замены генерируемых символов из valueS "\\" и "/" на числа таблицы ASCII в диапазоне Next  
                    if (valueS == '\\' || valueS == '/')
                    {
                        valueS = (char)RandomPassword.Next(65, 90);
                        // Добавление символов в список ListQuantitySymbols с конвертацией
                        ListQuantitySymbols.Add(valueS.ToString());
                    }
                    else if (valueS == ':' || valueS == ';' || valueS == '<' || valueS == '=' || valueS == '>' || valueS == '?'  || valueS == '|')
                    {
                        valueS = (char)RandomPassword.Next(97, 122);
                        ListQuantitySymbols.Add(valueS.ToString());
                    }
                    else if (valueS == '[' || valueS == ']' || valueS == '^' || valueS == '_'  || valueS == '@'  || valueS == '{'  || valueS == '}')
                    {
                        valueS = (char)RandomPassword.Next(65, 90);
                        ListQuantitySymbols.Add(valueS.ToString());
                    }
                    else if (check)
                    {
                        valueS = (char)RandomPassword.Next(97, 122);
                        ListQuantitySymbols.Add(valueS.ToString());
                    }
                    else
                    {
                        // Добавление символов в список ListQuantitySymbols с конвертацией
                        ListQuantitySymbols.Add(valueS.ToString());
                    }
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
        /// <summary>
        /// Using symbols on generate password: Letter upper register.
        /// </summary>
        public void LetterU()
        {
            Console.WriteLine("Сколько паролей");
            // конвертация string в int
            int QuantityPassword = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("Сколько символов в пароле");
            // конвертация string в int
            int QuantitySymbols = int.Parse(Console.ReadLine() ?? string.Empty);

            // Переменная для номера пароля
            int p = 0;

            // Цикл количества паролей
            for (int b = 1; b <= QuantityPassword; b++)
            {
                // Основная логика генерации пароля (FullPassword)
                for (int i = 0; i < QuantitySymbols; i++)
                {
                    // Рандомная генерация символов по таблице ASCII в диапазоне Next
                    char valueS = (char)RandomPassword.Next(65, 90);
                    ListQuantitySymbols.Add(valueS.ToString());
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
        /// <summary>
        /// Using symbols on generate password: Letter lower register.
        /// </summary>
        public void LetterL()
        {
            Console.WriteLine("Сколько паролей");
            // конвертация string в int
            int QuantityPassword = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("Сколько символов в пароле");
            // конвертация string в int
            int QuantitySymbols = int.Parse(Console.ReadLine() ?? string.Empty);

            // Переменная для номера пароля
            int p = 0;

            // Цикл количества паролей
            for (int b = 1; b <= QuantityPassword; b++)
            {
                // Основная логика генерации пароля (FullPassword)
                for (int i = 0; i < QuantitySymbols; i++)
                {
                    // Рандомная генерация символов по таблице ASCII в диапазоне Next
                    char valueS = (char)RandomPassword.Next(97, 122);
                    ListQuantitySymbols.Add(valueS.ToString());
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
        /// <summary>
        /// Using symbols on generate password: Number
        /// </summary>
        public void Number()
        {
            Console.WriteLine("Сколько паролей");
            // конвертация string в int
            int QuantityPassword = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("Сколько символов в пароле");
            // конвертация string в int
            int QuantitySymbols = int.Parse(Console.ReadLine() ?? string.Empty);

            // Переменная для номера пароля
            int p = 0;

            // Цикл количества паролей
            for (int b = 1; b <= QuantityPassword; b++)
            {
                // Основная логика генерации пароля (FullPassword)
                for (int i = 0; i < QuantitySymbols; i++)
                {
                    // Рандомная генерация символов по таблице ASCII в диапазоне Next
                    char valueS = (char)RandomPassword.Next(48, 57);
                    ListQuantitySymbols.Add(valueS.ToString());
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
        /// <summary>
        /// Using symbols on generate password: Special, Number, Letter upper register
        /// </summary>
        public void SpecialNumberLetterU()
        {
            Console.WriteLine("Сколько паролей");
            // конвертация string в int
            int QuantityPassword = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("Сколько символов в пароле");
            // конвертация string в int
            int QuantitySymbols = int.Parse(Console.ReadLine() ?? string.Empty);

            // Переменная для номера пароля
            int p = 0;

            // Цикл количества паролей
            for (int b = 1; b <= QuantityPassword; b++)
            {
                // Основная логика генерации пароля (FullPassword)
                for (int i = 0; i < QuantitySymbols; i++)
                {
                    // Рандомная генерация символов по таблице ASCII в диапазоне Next
                    char valueS = (char)RandomPassword.Next(33, 96);

                    // Логика замены генерируемых символов из valueS "\\" и "/" на числа таблицы ASCII в диапазоне Next  
                    if (valueS == '\\' || valueS == '/')
                    {
                        valueS = (char)RandomPassword.Next(123, 125);
                        // Добавление символов в список ListQuantitySymbols с конвертацией
                        ListQuantitySymbols.Add(valueS.ToString());
                    }
                    else
                    {
                        // Добавление символов в список ListQuantitySymbols с конвертацией
                        ListQuantitySymbols.Add(valueS.ToString());
                    }
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
        /// <summary>
        /// Using symbols on generate password: Special, Number, Letter lower register
        /// </summary>
        public void SpecialNumberLetterL()
        {
            Console.WriteLine("Сколько паролей");
            // конвертация string в int
            int QuantityPassword = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("Сколько символов в пароле");
            // конвертация string в int
            int QuantitySymbols = int.Parse(Console.ReadLine() ?? string.Empty);

            // Переменная для номера пароля
            int p = 0;

            // Цикл количества паролей
            for (int b = 1; b <= QuantityPassword; b++)
            {
                // Основная логика генерации пароля (FullPassword)
                for (int i = 0; i < QuantitySymbols; i++)
                {
                    // Рандомная генерация символов по таблице ASCII в диапазоне Next
                    char valueS = (char)RandomPassword.Next(33, 125);

                    // Логика замены генерируемых символов из valueS "\\" и "/" на числа таблицы ASCII в диапазоне Next  
                    if (valueS == '\\' || valueS == '/')
                    {
                        valueS = (char)RandomPassword.Next(33, 125);
                        // Добавление символов в список ListQuantitySymbols с конвертацией
                        ListQuantitySymbols.Add(valueS.ToString().ToLower());
                    }
                    else
                    {
                        // Добавление символов в список ListQuantitySymbols с конвертацией
                        ListQuantitySymbols.Add(valueS.ToString().ToLower());
                    }
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
        /// <summary>
        /// Using symbols on generate password: Special, Number
        /// </summary>
        public void SpecialNumber()
        {
            Console.WriteLine("Сколько паролей");
            // конвертация string в int
            int QuantityPassword = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("Сколько символов в пароле");
            // конвертация string в int
            int QuantitySymbols = int.Parse(Console.ReadLine() ?? string.Empty);

            // Переменная для номера пароля
            int p = 0;

            // Цикл количества паролей
            for (int b = 1; b <= QuantityPassword; b++)
            {
                // Основная логика генерации пароля (FullPassword)
                for (int i = 0; i < QuantitySymbols; i++)
                {
                    // Рандомная генерация символов по таблице ASCII в диапазоне Next
                    char valueS = (char)RandomPassword.Next(33, 64);
                    
                    // Логика замены генерируемых символов из valueS "\\" и "/" на числа таблицы ASCII в диапазоне Next  
                    if (valueS == '\\' || valueS == '/')
                    {
                        valueS = (char)RandomPassword.Next(91, 96);
                        // Добавление символов в список ListQuantitySymbols с конвертацией
                        ListQuantitySymbols.Add(valueS.ToString());
                    }
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
        /// <summary>
        /// Using symbols on generate password: Special, Letter upper register
        /// </summary>
        public void SpecialLetterU()
        {
            Console.WriteLine("Сколько паролей");
            // конвертация string в int
            int QuantityPassword = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("Сколько символов в пароле");
            // конвертация string в int
            int QuantitySymbols = int.Parse(Console.ReadLine() ?? string.Empty);

            // Переменная для номера пароля
            int p = 0;

            // Цикл количества паролей
            for (int b = 1; b <= QuantityPassword; b++)
            {
                // Основная логика генерации пароля (FullPassword)
                for (int i = 0; i < QuantitySymbols; i++)
                {
                    // Рандомная генерация символов по таблице ASCII в диапазоне Next
                    char valueS = (char)RandomPassword.Next(33, 125);

                    // Логика замены генерируемых символов из valueS "\\" и "/" на числа таблицы ASCII в диапазоне Next  
                    if (valueS == '\\' || valueS == '/')
                    {
                        valueS = (char)RandomPassword.Next(123, 125);
                        // Добавление символов в список ListQuantitySymbols с конвертацией
                        ListQuantitySymbols.Add(valueS.ToString().ToUpper());
                    }
                    else if (valueS == '0' || valueS == '2' || valueS == '4' || valueS == '5'  || valueS == '6')
                    {
                        valueS = (char)RandomPassword.Next(33, 47);
                        ListQuantitySymbols.Add(valueS.ToString().ToUpper());
                    }
                    else if (valueS == '7' || valueS == '8' || valueS == '9' || valueS == '1'  || valueS == '3')
                    {
                        valueS = (char)RandomPassword.Next(91, 96);
                        ListQuantitySymbols.Add(valueS.ToString().ToUpper());
                    }
                    else
                    {
                        // Добавление символов в список ListQuantitySymbols с конвертацией
                        ListQuantitySymbols.Add(valueS.ToString().ToUpper());
                    }
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
        /// <summary>
        /// Using symbols on generate password: Special, Letter lower register
        /// </summary>
        public void SpecialLetterL()
        {
            Console.WriteLine("Сколько паролей");
            // конвертация string в int
            int QuantityPassword = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("Сколько символов в пароле");
            // конвертация string в int
            int QuantitySymbols = int.Parse(Console.ReadLine() ?? string.Empty);

            // Переменная для номера пароля
            int p = 0;

            // Цикл количества паролей
            for (int b = 1; b <= QuantityPassword; b++)
            {
                // Основная логика генерации пароля (FullPassword)
                for (int i = 0; i < QuantitySymbols; i++)
                {
                    // Рандомная генерация символов по таблице ASCII в диапазоне Next
                    char valueS = (char)RandomPassword.Next(33, 125);

                    // Логика замены генерируемых символов из valueS "\\" и "/" на числа таблицы ASCII в диапазоне Next  
                    if (valueS == '\\' || valueS == '/')
                    {
                        valueS = (char)RandomPassword.Next(123, 125);
                        // Добавление символов в список ListQuantitySymbols с конвертацией
                        ListQuantitySymbols.Add(valueS.ToString().ToLower());
                    }
                    else if (valueS == '0' || valueS == '2' || valueS == '4' || valueS == '5'  || valueS == '6')
                    {
                        valueS = (char)RandomPassword.Next(33, 47);
                        ListQuantitySymbols.Add(valueS.ToString().ToLower());
                    }
                    else if (valueS == '7' || valueS == '8' || valueS == '9' || valueS == '1'  || valueS == '3')
                    {
                        valueS = (char)RandomPassword.Next(91, 96);
                        ListQuantitySymbols.Add(valueS.ToString().ToLower());
                    }
                    else
                    {
                        // Добавление символов в список ListQuantitySymbols с конвертацией
                        ListQuantitySymbols.Add(valueS.ToString().ToLower());
                    }
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
        /// <summary>
        /// Using symbols on generate password: Special
        /// </summary>
        public void Special()
        {
            
            
            Console.WriteLine("Сколько паролей");
            // конвертация string в int
            int QuantityPassword = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("Сколько символов в пароле");
            // конвертация string в int
            int QuantitySymbols = int.Parse(Console.ReadLine() ?? string.Empty);
            
            // Переменная для номера пароля
            int p = 0;

            // Цикл количества паролей
            for (int b = 1; b <= QuantityPassword; b++)
            {
                // Основная логика генерации пароля (FullPassword)
                for (int i = 0; i < QuantitySymbols; i++)
                {
                    // Regex - замена символов
                    const string versus = @"\w";
                    char swap = (char)RandomPassword.Next(33, 47);
                    Regex regex = new Regex(versus);
                    
                    // Рандомная генерация символов по таблице ASCII в диапазоне Next
                    char valueS = (char)RandomPassword.Next(33, 125);
                    
                    // Логика замены генерируемых символов из valueS "\\" и "/" на числа таблицы ASCII в диапазоне Next  
                    if (valueS == '\\' || valueS == '/')
                    {
                        valueS = (char)RandomPassword.Next(58, 64);
                        // Добавление символов в список ListQuantitySymbols с конвертацией
                        ListQuantitySymbols.Add(valueS.ToString());
                    }
                    else
                    {
                        string passSwap = regex.Replace(valueS.ToString(), swap.ToString());
                        
                        // Добавление символов в список ListQuantitySymbols с конвертацией
                        ListQuantitySymbols.Add(passSwap);
                    }
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
