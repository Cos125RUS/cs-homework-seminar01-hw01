﻿// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы


int EnterTheDot(string s)
{
    Console.Write(s + " = ");
    int dot = Random.Shared.Next(0, 10);
    Console.WriteLine(dot);
    return dot;
}

double FindX(int k1, int k2, int b1, int b2)
{
    double x = (b2 - b1) / (k1 - k2);
    //Console.WriteLine("x = " + x);
    return x;
}

double FindY(int k1, int b1, double x)
{
    double y = k1 * x + b1;
    //Console.WriteLine("y = " + y);
    return y;
}


int k1 = EnterTheDot("k1");
int k2 = EnterTheDot("k2");
int b1 = EnterTheDot("b1");
int b2 = EnterTheDot("b2");

double x = FindX(k1, k2, b1, b2);
double y = FindY(k1, b1, x);

Console.WriteLine("Crossing dot: [" + x + ";" + y + "]");