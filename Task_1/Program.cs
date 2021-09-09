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
        switch (i)
        {
          case 0:
            Console.WriteLine("Именительный: "+word);
            break;
          case 1:
            Console.WriteLine("Родительный: "+word+"А");
            break;
          case 2:
            Console.WriteLine("Дательный: "+word+"У");
            break;
          case 3:
            Console.WriteLine("Винительный: "+word+"А");
            break;
          case 4:
            Console.WriteLine("Творительный: "+word+"ОМ");
            break;
          case 5:
            Console.WriteLine("Предложный: "+"О "+word+"Е");
            break;
        }
      }

      Console.ReadKey();
    }
  }
}