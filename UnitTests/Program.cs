using Solver;

double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());

var result = Solve.SolveEquation(a, b, c);

Console.WriteLine($"{result[0]} {result[1]}");