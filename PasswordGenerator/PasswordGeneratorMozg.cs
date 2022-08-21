//using System;

//namespace PasswordGeneratorMozg
//{
//    class Mozg
//    {
//        static void Main(string[] args)
//        {
//            // Дописать все возможные варианты

//            // Пременные для сравнения registr
//            string registrUL = "UL";
//            string registrul = "ul";
//            string registrU = "U";
//            string registru = "u";
//            string registrL = "L";
//            string registrl = "l";

//            // Переменные для сравнния number
//            string numberY = "Y";
//            string numbery = "y";
//            string numberN = "N";
//            string numbern = "n";

//            // Символы для пароля
//            string abc = "abcdefghijklmnopqrstuwxyz";
//            string ABC = "ABCDEFGHIJKLMNOPQRSTUWXYZ";
//            string numbers = "0123456789";
//            string symbols = "!@#$%^&*()";

//            string abcABCNumbersSymbols = "abcdefghijklmnopqrstuwxyzABCDEFGHIJKLMNOPQRSTUWXYZ0123456789!@#$%^&*()";

//            // Пременные для сравнения specSymbol
//            string specSymbolY = "Y";
//            string specSymboly = "y";
//            string specSymbolN = "N";
//            string specSymboln = "n";

//            Console.WriteLine("Сколько символов в пароле?");
//            string? inputSumSymbols = Console.ReadLine();
//            int sumSymbols = Convert.ToInt32(inputSumSymbols); // Convert string to int

//            Console.WriteLine("Сколько паролей?");
//            string? inputSumPassword = Console.ReadLine();
//            int sumPassword = Convert.ToInt32(inputSumPassword); // Convert string to int

//            List<string> listSumPasswordSymbols = new List<string>(); // Основноый список
//            List<string> listSumPassword = new List<string>(); // Для кол-ва

//            Random randomnPassword = new Random();

//            string[] strings = new string[sumSymbols]; // Основной массив

//            Console.WriteLine("Использовать вехний и нижний, или только верхний или нижний регистр символом? \nUL/U/L");
//            string? inputRegistr = Console.ReadLine();


//            if ((registrUL == inputRegistr) | (registrul == inputRegistr))
//            {
//                //bool registerY = Convert.ToBoolean(inputRegistr); // Convert string to bool
//                Console.WriteLine("Использовать цифры? \nY/N");
//                string? inputNumber = Console.ReadLine();

//                if ((numberY == inputNumber) | (numbery == inputNumber))
//                {
//                    //Console.WriteLine("Использовать цифры");
//                    Console.WriteLine("Использовать специальные символы? \nY/N");
//                    string? inputSpecSymbol = Console.ReadLine();

//                    if ((specSymbolY == inputSpecSymbol) | (specSymboly == inputSpecSymbol))
//                    {
//                        //Console.WriteLine("Со спецециальными символами");
//                        Console.WriteLine("Верхний и нижний регистр");
//                        //string passwordULNS = string.Concat(abc, ABC, numbers, symbols);

//                        for (int b = 0; b >= sumPassword; b++)
//                        {
//                            // Основная логика
//                            for (int i = 0; i<sumSymbols; i++)
//                            {
//                                int value = randomnPassword.Next(0, 9);
//                                string valueString = Convert.ToString(value);
//                                char valueS = (char)randomnPassword.Next(33, 125);
//                                if (valueS == '\\' || valueS == '/')
//                                {
//                                    valueS = (char)randomnPassword.Next(33, 91);
//                                    //Console.WriteLine($"IFPassword №:{i} -> {valueS}");
//                                    valueS.ToString();
//                                    listSumPasswordSymbols.Add(valueS.ToString());
//                                }
//                                else
//                                {
//                                    //Console.WriteLine($"ELSEPassword №:{i} -> {valueS}");

//                                    // Копирует в список
//                                    listSumPasswordSymbols.Add(valueS.ToString());
//                                }

//                                // Копирует список в массив
//                                listSumPasswordSymbols.CopyTo(strings);
//                            }

//                            // проверка списка
//                            //foreach (string listSumPasswordSymbolsS in ListQuantitySymbols)
//                            //{
//                            //    Console.WriteLine($"Symbol: {listSumPasswordSymbolsS}");
//                            //}

//                            listSumPasswordSymbols.Clear(); // clear список

//                            // добавить элементы из массива в список
//                            listSumPasswordSymbols.AddRange(strings);

//                            Console.ForegroundColor = ConsoleColor.Magenta; // Цвет текста в консоли
//                            Console.Write("\nPassword: ");
//                            Console.ResetColor(); // Вернуть цвет в стандартный

//                            // Вывод пароля
//                            foreach (string listSumPasswordSymbolsS1 in listSumPasswordSymbols)
//                            {
//                                Console.ForegroundColor = ConsoleColor.Yellow;
//                                Console.Write(listSumPasswordSymbolsS1);
//                                Console.ResetColor();
//                                listSumPassword.Add(listSumPasswordSymbolsS1);
//                            }


//                            Console.ForegroundColor = ConsoleColor.White; // Цвет текста в консоли
//                            Console.Write("\nPasswordSSS: ");
//                            Console.ResetColor(); // Вернуть цвет в стандартный

//                            // Вывод пароля
//                            foreach (string listSumPasswordSymbolsS2 in listSumPassword)
//                            {
//                                Console.ForegroundColor = ConsoleColor.Cyan;
//                                Console.Write(listSumPasswordSymbolsS2);
//                                Console.ResetColor();
//                            }
//                        }
//                    }
//                    else if ((specSymbolN == inputSpecSymbol) | (specSymboln == inputSpecSymbol))
//                    {
//                        Console.WriteLine("Без специальных символов");
//                    }
//                    else
//                    {
//                        Console.WriteLine("ERROR"); // Ошибка
//                    }
//                }
//                else if ((numberN == inputNumber) | (numbern == inputNumber))
//                {
//                    Console.WriteLine("Не использовать цифры");

//                    //Console.WriteLine("Использовать цифры");
//                    Console.WriteLine("Использовать специальные символы? \nY/N");
//                    string? inputSpecSymbol = Console.ReadLine();

//                    if ((specSymbolY == inputSpecSymbol) | (specSymboly == inputSpecSymbol))
//                    {
//                        //Console.WriteLine("Со спецециальными символами");
//                        Console.WriteLine("Верхний и нижний регистр");
//                        //string passwordULNS = string.Concat(abc, ABC, numbers, symbols);

//                        // Основная логика
//                        for (int i = 0; i<sumSymbols; i++)
//                        {
//                            //int value = randomPassword.Next(0, 9);
//                            //string valueString = Convert.ToString(value);
//                            char valueS = (char)randomnPassword.Next(47, 125);
//                            if (valueS == '\\' || valueS == '/')
//                            {
//                                valueS = (char)randomnPassword.Next(47, 91);
//                                //Console.WriteLine($"IFPassword №:{i} -> {valueS}");
//                                valueS.ToString();
//                                listSumPasswordSymbols.Add(valueS.ToString());
//                            }
//                            else
//                            {
//                                //Console.WriteLine($"ELSEPassword №:{i} -> {valueS}");

//                                // Копирует в список
//                                listSumPasswordSymbols.Add(valueS.ToString());
//                            }

//                            // Копирует список в массив
//                            listSumPasswordSymbols.CopyTo(strings);
//                        }

//                        // проверка списка
//                        //foreach (string listSumPasswordSymbolsS in ListQuantitySymbols)
//                        //{
//                        //    Console.WriteLine($"Symbol: {listSumPasswordSymbolsS}");
//                        //}

//                        listSumPasswordSymbols.Clear(); // clear список

//                        // добавить элементы из массива в список
//                        listSumPasswordSymbols.AddRange(strings);

//                        Console.ForegroundColor = ConsoleColor.Magenta; // Цвет текста в консоли
//                        Console.Write("\nPassword: ");
//                        Console.ResetColor(); // Вернуть цвет в стандартный

//                        // Вывод пароля
//                        foreach (string listSumPasswordSymbolsS1 in listSumPasswordSymbols)
//                        {
//                            Console.ForegroundColor = ConsoleColor.Yellow;
//                            Console.Write(listSumPasswordSymbolsS1);
//                            Console.ResetColor();
//                        }

//                    }
//                    else if ((specSymbolN == inputSpecSymbol) | (specSymboln == inputSpecSymbol))
//                    {
//                        Console.WriteLine("Без специальных символов");
//                    }
//                    else
//                    {
//                        Console.WriteLine("ERROR"); // Ошибка
//                    }

//                }
//                else
//                {
//                    Console.WriteLine("ERROR"); // Ошибка
//                }



//            }
//            else if ((registrU == inputRegistr) | (registru == inputRegistr) | (registrL == inputRegistr) | (registrl == inputRegistr))
//            {
//                Console.WriteLine("Верхний или нижний регистр?");
//                if ((registrU == inputRegistr) | (registru == inputRegistr))
//                {
//                    Console.WriteLine("Верхний регистр");

//                    Console.WriteLine("Использовать специальные символы? \nY/N");
//                    string? inputSpecSymbol = Console.ReadLine();

//                    if ((specSymbolY == inputSpecSymbol) | (specSymboly == inputSpecSymbol))
//                    {
//                        Console.WriteLine("Со спецециальными символами");
//                    }
//                    else if ((specSymbolN == inputSpecSymbol) | (specSymboln == inputSpecSymbol))
//                    {
//                        Console.WriteLine("Без специальных символов");
//                    }
//                    else
//                    {
//                        Console.WriteLine("ERROR"); // Ошибка
//                    }
//                }
//                else if ((registrL == inputRegistr) | (registrl == inputRegistr))
//                {
//                    Console.WriteLine("Нижний регистр");

//                    Console.WriteLine("Использовать специальные символы? \nY/N");
//                    string? inputSpecSymbol = Console.ReadLine();

//                    if ((specSymbolY == inputSpecSymbol) | (specSymboly == inputSpecSymbol))
//                    {
//                        Console.WriteLine("Со спецециальными символами");
//                    }
//                    else if ((specSymbolN == inputSpecSymbol) | (specSymboln == inputSpecSymbol))
//                    {
//                        Console.WriteLine("Без специальных символов");
//                    }
//                    else
//                    {
//                        Console.WriteLine("ERROR"); // Ошибка
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("ERROR#2"); // Ошибка
//                }
//            }
//            else
//            {
//                Console.WriteLine("ERROR#1"); // Ошибка
//            }






//            // Тут где-то логика будет
//            //if(UL == 1)
//            //{
//            //    string passwordULNS = string.Concat(abc, ABC, numbers, symbols);
//            //    Console.WriteLine("logIf");
//            //    Console.WriteLine(passwordULNS);
//            //}
//            //else if()
//            //{
//            //    Console.WriteLine("logElseIf");
//            //}
//            //else
//            //{
//            //    Console.WriteLine("logElse");
//            //}




//        }
//    }
//}