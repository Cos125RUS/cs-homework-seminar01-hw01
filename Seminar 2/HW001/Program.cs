// Задача 10: Напишите метод, который принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int num = Random.Shared.Next(100, 999);

Console.WriteLine("num = "+num);

void AverageNumber(int num)
{
    num /=10;
    num%=10;
    Console.WriteLine("Average number - "+num);
}

AverageNumber(num);