using System;

namespace Task_1
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Введите e и x");
      double e = Double.Parse(Console.ReadLine()), S = 0;
      int x = Int32.Parse(Console.ReadLine());
      ulong r;
      int n = 0;
      double a = 1;
      while (a > e)
      {
        r = 1;
        n++;
        for (int i = 1; i <= n + 2; i++) r *= (ulong) i;
        a = x * (n + 1.0) / r;
        S += a;
      }
      Console.WriteLine($"{a}");
      Console.ReadLine();
    }
  }
}