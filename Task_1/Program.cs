using System;

namespace Task_1
{
  class Program
  {
    public static void Main(string[] args)
    {
      const int n = 32;
      int[] A = new int[n];
      Console.WriteLine($"Введите {n} чисел");
      for (int i = 0; i < n; i++)
      {
        A[i] = Int32.Parse(Console.ReadLine());
      }

      int m = 0, nul = 0;
      for(int i = 0; i < n; i++)
      {
        if (A[i] < 0 && i < 20) m++;
        else if (i == 0) nul++;
      }
      Console.WriteLine($"Количество отрицательных: {m}, Количество нулей {nul}");
      Console.ReadKey();
    }
  }
}