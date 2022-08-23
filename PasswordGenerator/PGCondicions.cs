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
        /*Удалить*/

        private int a;
        private int g;

        public Regex regex = new Regex("");

        /*Удалить*/

        public void NumberSymbols()
        {
            Console.WriteLine("Сколько паролей");
            // конвертация string в int
            int QuantityPassword = int.Parse(Console.ReadLine());

            Console.WriteLine("Сколько символов в пароле");
            // конвертация string в int
            int QuantitySymbols = int.Parse(Console.ReadLine());

            string[] strings = new string[QuantitySymbols]; // Основной массив

            // Тестовый модуль замены символов
            string UseNumSymbols = "0 1 2 3 4 5 6 7 8 9 ! # $ % & ' ( ) * + , - . : ; < = > ? @ [ ] | ^ _ { }";
            string SearchNumSymbols = "a b c d e f g h i j k l m n o p q r s t u w x y z A B C D E F G H I J K L M N O P Q R S T U W X Y Z";
            string[] UseNumSymbolsArray = UseNumSymbols.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] SearchNumSymbolsArray = SearchNumSymbols.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //foreach (string i in UseNumSymbolsArray)
            //{
            //    Console.WriteLine(i);
            //}
            //

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
                        //Console.WriteLine($"IFPassword №:{i} -> {valueS}"); // Проверка
                        valueS.ToString();

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

                    // Копирует список в массив strings
                    ListQuantitySymbols.CopyTo(strings);
                }

                // Переменная для номера пароля
                p++;

                //// Проверка списка
                //foreach (string listSumPasswordSymbolsS in ListQuantitySymbols)
                //{
                //    Console.WriteLine($"Symbol: {listSumPasswordSymbolsS}");
                //}

                // Ищет какой знак заменить
                bool pas1 = ListQuantitySymbols.Contains(SearchNumSymbolsArray.ToString());

                // Рандомная генерация символов по таблице ASCII в диапазоне 33 - 125
                char valueS1 = (char)randomPassword.Next(48, 57);
                string GenPas = Convert.ToString(valueS1);

                if (pas1 == true)
                {
                    //string pattern = ""

                    //////Console.WriteLine("####################");
                    ////ListQuantitySymbols.RemoveAt(b);
                    //ListQuantitySymbols.Insert(b, );

                    ////MatchCollection match = regex.Matches(SearchNumSymbolsArray.ToString());

                    //ListQuantitySymbols.



                }
                else
                {


                    /*Удалить*/

                    int c = a + g;

                    /*Удалить*/
                }

                Console.ForegroundColor = ConsoleColor.Magenta; // Изменяет цвет текста в консоли на Magenta
                Console.Write($"\nPasswordTest {p}: ");
                Console.ResetColor(); // Изменяет цвет текста в коноли на стандартный

                // Вывод пароля и перебор
                foreach (string listSumPasswordSymbolsS1 in ListQuantitySymbols)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow; // Изменяет цвет текста в консоли на Yellow



                    Console.Write($"{listSumPasswordSymbolsS1}");
                    Console.ResetColor(); // Изменяет цвет текста в коноли на стандартный
                    ListQuantityPasswords.Add(listSumPasswordSymbolsS1);
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

            // Тестовый модуль замены символов
            string UseNumSymbols = "0 1 2 3 4 5 6 7 8 9 ! # $ % & ' ( ) * + , - . : ; < = > ? @ [ ] | ^ _ { }";
            string SearchNumSymbols = "a b c d e f g h i j k l m n o p q r s t u w x y z A B C D E F G H I J K L M N O P Q R S T U W X Y Z";
            string[] UseNumSymbolsArray = UseNumSymbols.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] SearchNumSymbolsArray = SearchNumSymbols.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //foreach (string i in UseNumSymbolsArray)
            //{
            //    Console.WriteLine(i);
            //}
            //

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
                        //Console.WriteLine($"IFPassword №:{i} -> {valueS}"); // Проверка
                        valueS.ToString();

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

                    // Копирует список в массив strings
                    ListQuantitySymbols.CopyTo(strings);
                }

                // Переменная для номера пароля
                p++;

                //// Проверка списка
                //foreach (string listSumPasswordSymbolsS in ListQuantitySymbols)
                //{
                //    Console.WriteLine($"Symbol: {listSumPasswordSymbolsS}");
                //}

                // Ищет какой знак заменить
                bool pas1 = ListQuantitySymbols.Contains(SearchNumSymbolsArray.ToString());

                // Рандомная генерация символов по таблице ASCII в диапазоне 33 - 125
                char valueS1 = (char)randomPassword.Next(48, 57);
                string GenPas = Convert.ToString(valueS1);

                foreach (string ListQuantitySymbols5 in ListQuantitySymbols)
                {
                    string pattern = @"\W";
                    string swap = "_";
                    Regex regex = new Regex(pattern);

                    string passSwap = regex.Replace(ListQuantitySymbols.ToString(), swap);
                    Console.WriteLine($"PasswordSwap: {passSwap}");
                }
                

                if (pas1 == true)
                {
                    

                    //Console.WriteLine("####################");
                    ////ListQuantitySymbols.RemoveAt(b);
                    //ListQuantitySymbols.Insert(b, );

                    ////MatchCollection match = regex.Matches(SearchNumSymbolsArray.ToString());

                    //ListQuantitySymbols.



                }
                else
                {


                    /*Удалить*/

                    int c = a + g;

                    /*Удалить*/
                }

                Console.ForegroundColor = ConsoleColor.Magenta; // Изменяет цвет текста в консоли на Magenta
                Console.Write($"\nPasswordTest {p}: ");
                Console.ResetColor(); // Изменяет цвет текста в коноли на стандартный

                // Вывод пароля и перебор
                foreach (string listSumPasswordSymbolsS1 in ListQuantitySymbols)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow; // Изменяет цвет текста в консоли на Yellow



                    Console.Write($"{listSumPasswordSymbolsS1}");
                    Console.ResetColor(); // Изменяет цвет текста в коноли на стандартный
                    ListQuantityPasswords.Add(listSumPasswordSymbolsS1);
                }

                // Очистка списка
                ListQuantitySymbols.Clear();
            }
        }
    }
}
