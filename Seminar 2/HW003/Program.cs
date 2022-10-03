// Напишите метод, который принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void Weekends()
{
    Console.Write("Enter the day (1-7): ");
    int day = Convert.ToInt32(Console.ReadLine());

    if (day > 5) Console.WriteLine("Weekends!");
    else Console.WriteLine("Dull gray working day =(");
}

Weekends();