// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// Пример: b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


int EnterTheDot(string s)
{
    Console.Write(s + " = ");
    int dot = Convert.ToInt32(Console.ReadLine());    
    return dot;
}

double FindX(int k1, int k2, int b1, int b2)
{
    double x = b2 - b1;
    x = x / (k1 - k2);    
    return x;
}

double FindY(int k1, int b1, double x)
{
    double y = k1 * x + b1;    
    return y;
}


int k1 = EnterTheDot("k1");
int k2 = EnterTheDot("k2");
int b1 = EnterTheDot("b1");
int b2 = EnterTheDot("b2");

double x = FindX(k1, k2, b1, b2);
double y = FindY(k1, b1, x);

Console.WriteLine("Crossing dot: [" + x + ";" + y + "]");