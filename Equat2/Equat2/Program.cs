using System;


namespace Equat2
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());

            var result = Solve(a, b, c);

            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);
        }
        public static double[] Solve(double a, double b, double c)
        {
            if (a == 0)
            {
                if (b == 0) return new double[0];
                else return new double[] { -c / b };
            }
            var discriminant = b * b - 4 * a * c;
            if (discriminant > 0)
            {
                var x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                var x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return new[] { x1, x2 };
            }
            else if (discriminant == 0)
                return new[] { -b / (2 * a) };

            else return new double[0];

        }
    }
}
