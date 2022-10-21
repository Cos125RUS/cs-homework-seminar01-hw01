// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем

void Subsequence(int count, int n1, int n2)
{
    if (count > 2)
    {
        int sum = n1 + n2;
        Console.WriteLine(sum);
        Subsequence(count - 1, n2, sum);
    }
}

int AlternativeOption(int number, int a, int b)
{
    if (number == 1) return a;
    else
    {
        if (number == 2) return b;
        else
        {
            // Console.WriteLine(AlternativeOption(number, a, b));
            return (AlternativeOption(number - 2, a, b) + AlternativeOption(number - 1, a, b));
        }
    }
}

System.Console.Write("Sequence length = ");
int count = Convert.ToInt32(Console.ReadLine());

Console.Write("Number 1 = ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Number 2 = ");
int number2 = Convert.ToInt32(Console.ReadLine());

Subsequence(count, number1, number2);
System.Console.WriteLine();
// int n = AlternativeOption(count, number1, number2);
// Console.WriteLine(n);