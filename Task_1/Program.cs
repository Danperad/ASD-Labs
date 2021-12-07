using System;

namespace Task_1
{
  class Program
  {
    public static void Main(string[] args)
    {
      double n = 30;
      double m = 2;

      Console.WriteLine($"Ответ: {Factorial(n)/ (Factorial(m) * Factorial(n-m))}");
      Console.ReadKey();
    }

    private static double Factorial(double i)
    {
      if (i == 0 || Math.Abs(i - 1) < 0.0000001) return i;
      return i * Factorial(i-1);
    }
  }
}