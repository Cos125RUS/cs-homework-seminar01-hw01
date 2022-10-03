// 8. Показать четные числа от 1 до N

Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[n];

int i = 0;
while (i < n)
{
    numbers[i] = i + 1;
    if (numbers[i]%2==0) Console.WriteLine(numbers[i]);
    i++;
}

