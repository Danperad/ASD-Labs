using System;

namespace Task_1
{
  class Program
  {
    public static void Main(string[] args)
    {
      for (double i = 1; i <= 5; i+=0.4)
      {
        double y = Math.Log(i * i) + 3 * i;
        Console.WriteLine($"При x = {i}, y = {y}");
      }

      Console.ReadKey();
    }
  }
}