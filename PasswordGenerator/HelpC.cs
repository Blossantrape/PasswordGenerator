namespace PasswordGenerator
{
    class HelpC : Input
    {
        public void Help()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Optional password:\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("1) Full - Using symbols on generate password: All.\n" +
                              "2) NLUL - Using symbols on generate password: Number, Letter upper and lower register.\n" +
                              "3) NLU - Using symbols on generate password: Number, Letter Upper register.\n" +
                              "4) NLL - Using symbols on generate password: Number, Letter lower.\n" +
                              "4) LUL - Using symbols on generate password: Letter upper and lower register.\n" +
                              "5) LU - Using symbols on generate password: Letter upper register.\n" +
                              "6) LL - Using symbols on generate password: Letter lower register.\n" +
                              "7) N - Using symbols on generate password: Number.\n" +
                              "8) SNLU - Using symbols on generate password: Special, Number, Letter upper register.\n" +
                              "9) SNLL - Using symbols on generate password: Special, Number, Letter lower register.\n" +
                              "10) SN - Using symbols on generate password: Special, Number.\n" +
                              "11) SLU - Using symbols on generate password: Special, Letter upper register.\n" +
                              "12) SLL - Using symbols on generate password: Special, Letter lower register.\n" +
                              "13) S - Using symbols on generate password: Special.\n");
            Console.ResetColor();
        }
    }
}
