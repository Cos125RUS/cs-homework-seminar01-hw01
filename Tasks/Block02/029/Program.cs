// Написать программу вычисления произведения чисел от 1 до N

int n = new Random().Next(1, 50);
Console.WriteLine("N = " + n);

long multi = 1;

for (int i = 1; i <= n; i++)
{
    multi *= i;
}

Console.WriteLine("Multiplication = " + multi);