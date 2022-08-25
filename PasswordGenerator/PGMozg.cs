namespace PasswordGenerator
{
    class PGMozg : PGMain
    {
        /// <summary>
        /// Using symbols on generate password: All.
        /// </summary>
        public void FullPassword()
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
                    char valueS = (char)RandomPassword.Next(33, 125);

                    // Логика замены генерируемых символов из valueS "\\" и "/" на числа таблицы ASCII в диапазоне 33 - 125  
                    if (valueS == '\\' || valueS == '/')
                    {
                        valueS = (char)RandomPassword.Next(33, 91);
                        //Console.WriteLine($"IFPassword №:{i} -> {valueS}"); // Проверка

                        // Добавление символов в список ListQuantitySymbols с конвертацией
                        ListQuantitySymbols.Add(valueS.ToString());
                    }

                    // Если в генерации не попались символы "\\" и "/"
                    else
                    {
                        //Console.WriteLine($"ELSEPassword №:{i} -> {valueS}"); // Проверка

                        // Добавление символов в список ListQuantitySymbols с конвертацией
                        ListQuantitySymbols.Add(valueS.ToString());
                    }
                }

                // Переменная для номера пароля
                p++;

                // проверка списка
                //foreach (string listSumPasswordSymbolsS in ListQuantitySymbols)
                //{
                //    Console.WriteLine($"Symbol: {listSumPasswordSymbolsS}");
                //}

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
    }
}
