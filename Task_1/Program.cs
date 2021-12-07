using System;

namespace Task_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            double b, q, bn;
            int n;
            Console.Write("Введите первый член геометрической прогрессии: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите q: ");
            q = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите конечный член геометрической прогрессии: ");
            bn = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите c какого члена геометрической прогрессии искать частичную сумму: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(bn + " член геометрической прогрессии = " + GeometriProg(b, q, bn));
            Console.WriteLine($"Сумма {bn} членов геометрической прогрессии = " + SumGeometriProg(b, q, bn, 0));
            Console.WriteLine($"Сумма {bn - n} членов геометрической прогрессии от {n} до {bn} = " +
                              SumGeometriProg(b, q, bn, n));
        }
        private static double GeometriProg(double b, double q, double bn, double m = 1)
        {
            if (bn < 2) return b * m;
            m *= q;
            return GeometriProg(b, q, --bn, m);
        }

        private static double SumGeometriProg(double b, double q, double bn, double n, double m = 1, double sum = 0)
        {
            if (bn < n) return sum;
            sum += GeometriProg(b, q, bn, m);
            sum = SumGeometriProg(b, q, --bn, n, m, sum);
            return sum;
        }
    }
}