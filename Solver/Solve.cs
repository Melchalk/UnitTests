using System;

namespace Solver;

public class Solve
{
    public static double[] SolveEquation(double a, double b, double c)
    {
        var D = b * b - 4 * a * c;

        double x1 = (-b - Math.Sqrt(D)) / (2 * a);
        double x2 = (-b + Math.Sqrt(D)) / (2 * a);

        if (D > 0)
        {
            return new[]
            {
                x1, x2
            };
        }
        else if (D == 0)
        {
            return new[]
            {
                x1
            };
        }

        return Array.Empty<double>();
    }
}