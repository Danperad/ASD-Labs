using System;

namespace Task_1
{
  class Program
  {
    public static void Main(string[] args)
    {
      const int n = 32;
      int m = 0, nul = 0;
      int[] A = new int[n];
      var rand = new Random();
      for (int i = 0; i < n; i++)
      {
        A[i] = rand.Next(-10, 10);
      }
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