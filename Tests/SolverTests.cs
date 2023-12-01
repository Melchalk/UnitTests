using Solver;
using System;

namespace Tests;

public class Tests
{
    void TestEquation(double a, double b, double c, params double[] expectedResult)
    {
        var result = Solve.SolveEquation(a, b, c);

        Assert.That(result, Has.Length.EqualTo(expectedResult.Length));

        for (int i = 0; i < result.Length; i++)
        {
            Assert.That(result[i], Is.EqualTo(expectedResult[i]));
        }
    }

    [Test]
    public void OrdinaryEquation()
    => TestEquation(1, -3, 2, 1, 2);

    [Test]
    public void ZeroDiscriminant()
    => TestEquation(1, 2, 1, -1);

    [TestCase(4, 4, 5)]
    [TestCase(1, 0, 1)]
    public void NegativeDiscriminant(double a, double b, double c)
    => TestEquation(a, b, c);

    [Test]
    public void FuncTest()
    {
        for (int i = 0; i < 100; i++)
        {
            var rnd = new Random();

            double a = rnd.NextDouble() * 10;
            double b = rnd.NextDouble() * 10;
            double c = rnd.NextDouble() * 10;

            var result = Solve.SolveEquation(a, b, c);

            foreach (var x in result)
                Assert.That(a * x * x + b * x + c, Is.EqualTo(0).Within(1e-10));
        }
    }
}