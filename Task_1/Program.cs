using System;

namespace Task_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string word = "СТУДЕНТ";
            for (int i = 0; i < 6; i++)
            {
                if (i == 0) Console.WriteLine("Именительный: " + word);
                else if (i == 1) Console.WriteLine("Родительный: " + word + "А");
                else if (i == 2) Console.WriteLine("Дательный: " + word + "У");
                else if (i == 3) Console.WriteLine("Винительный: " + word + "А");
                else if (i == 4) Console.WriteLine("Творительный: " + word + "ОМ");
                else if (i == 5) Console.WriteLine("Предложный: " + "О " + word + "Е");
            }
            Console.ReadKey();
        }
    }
}