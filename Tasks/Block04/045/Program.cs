// Показать числа Фибоначчи

int Fibonachi(int n)
{
    if (n == 0 || n == 1) return 1;
    else return Fibonachi(n - 2) + Fibonachi(n - 1);
}

void Print(int n)
{
    int f;
    for (int i = 0; i < n; i++)
    {
        f = Fibonachi(i);        
        Console.Write(f + ", ");
    }
    Console.Write(Fibonachi(n));
}


Console.Write("Number of Fibonachi = ");
int n = Convert.ToInt32(Console.ReadLine());

Print(n);