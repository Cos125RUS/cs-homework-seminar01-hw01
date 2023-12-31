﻿// Написать программу масштабирования фигуры

// Тут для тех, кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"



int Counter(string s)
{
    int counter = 0;

    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == ',') counter++;
    }
    return counter;
}

void Converter(string s, double[] array, int n)
{
    string[] comma, left, right;
    comma = s.Split(',');
    int j = 0;

    for (int i = 0; i <= n; i++)
    {
        if (i != 0 && i != n)
        {
            left = comma[i].Split(')');
            array[j] = Convert.ToDouble(left[0]);
            j++;
            right = left[1].Split('(');
            array[j] = Convert.ToDouble(right[1]);
            j++;
        }
        else
        {
            if (i == 0)
            {
                right = comma[i].Split('(');
                array[j] = Convert.ToDouble(right[1]);
                // Console.WriteLine(i + " = " + comma[i] + " to " + array[j]);
                j++;
            }
            else
            {
                right = comma[i].Split(')');
                array[j] = Convert.ToDouble(right[0]);
            }
        }
        // Console.WriteLine(i + " = " + comma[i] + ' ');        
    }
    // System.Console.WriteLine(String.Join(' ', array));
}

void Scaling(double[] array, double k, int n)
{
    // System.Console.WriteLine(String.Join(' ', array));
    for (int i = 0; i < n * 2; i++)
    {
        array[i] *= k;
    }
    // System.Console.WriteLine(String.Join(' ', array));
}

void Print(double[] array, int n)
{
    for (int i = 0; i < n * 2; i += 2)
    {
        Console.Write("(" + array[i] + "," + array[i + 1] + ") ");
    }
}


Console.Write("Enter coordinates: ");
string enter = Console.ReadLine();

double k;
do
{
    Console.Write("k = ");
    k = Convert.ToDouble(Console.ReadLine());
    // Console.WriteLine(k);
    if (k < 0) Console.WriteLine("Error! Try again");
} while (k < 0);

int size = Counter(enter);
double[] array = new double[size * 2];

Converter(enter, array, size);
// System.Console.WriteLine(String.Join(' ', array));

Scaling(array, k, size);
Print(array, size);