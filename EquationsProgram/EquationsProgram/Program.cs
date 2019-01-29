using Solver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquationsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());

            var result = QuadraticEquationsSolver.Solve(a, b, c);

            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);
        }
    }
}
