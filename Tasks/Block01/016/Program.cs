// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

void Weekends()
{
    Console.Write("Enter the day (1-7): ");
    int day = Convert.ToInt32(Console.ReadLine());

    if (day > 5) Console.WriteLine("Weekends!");
    else Console.WriteLine("Dull gray working day =(");
}

Weekends();