//Написать программу вычисления значения функции y = f(a) (Sin(a + Cos(1/a))

int a;
double y;

Console.Write("a = ");
a = Convert.ToInt32(Console.ReadLine());

y = Math.Sin(a + Math.Cos(1/a));

Console.Write("y = "+y);
