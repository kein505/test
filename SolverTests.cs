using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solver.Tests
{
    [TestClass]
    public class SolverTest
    {
        void TestEquations(double a, double b, double c, params double[] exceptedResult)
        {
            var result = QuadraticEquationsSolver.Solve(a, b, c);

            Assert.AreEqual(exceptedResult.Length, result.Length);

            for (int i = 0; i < result.Length; i++)
                Assert.AreEqual(exceptedResult[i], result[i]);
        }

        [TestMethod]
        public void OrdinaryEquation()
        {
            TestEquations(1, -3, 2, 2, 1);
        }
        [TestMethod]
        public void NegativeDiscriminant()
        {
            TestEquations(1, 1, 1);
        }
        [TestMethod]
        public void ZeroDiscriminant()
        {
            TestEquations(1, 2, 1, -1);
        }
        [TestMethod]
        public void ZeroA()
        {
            TestEquations(0, -1, 1, 1);
        }
        [TestMethod]
        public void ZeroAandB()
        {
            TestEquations(0, 0, 1);
        }
        [TestMethod]
        public void FunctionalTest()
        {
            for (int i = 0; i < 100; i++)
            {
                var rnd = new Random();
                var a = rnd.NextDouble() * 10;
                var b = rnd.NextDouble() * 10;
                var c = rnd.NextDouble() * 10;
                var result = QuadraticEquationsSolver.Solve(a, b, c);
                foreach (var x in result)
                {
                    Assert.AreEqual(0, a * x * x + b * x + c,1e-10);
                }
            }
        }
    }
}
