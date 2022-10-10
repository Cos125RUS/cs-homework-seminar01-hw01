// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void Distance3D()
{
    double GetValue(string text)
    {
        double value = Convert.ToDouble(Console.ReadLine());
        return value;
    }

    void Print(double ax, double ay, double az, double bx, double by, double bz, double result)
    {
        string output = "A(" + ax + ", " + ay + ", "+az+"); B(" + bx + ", " + by + ", "+bz+"), -> " + result;
        Console.WriteLine(output);
    }

    double GetDistance3D(double ax, double ay, double az, double bx, double by, double bz)
    {
        double x = Math.Pow(ax - bx, 2);
        double y = Math.Pow(ay - by, 2);
        double z = Math.Pow(az - bz, 2);
        double result = Math.Sqrt(x + y + z);
        result = Math.Round(result, 2);
        return result;
    }

    Console.WriteLine("Point A coordinates:");
    Console.Write("x: ");
    double ax = GetValue("ax");
    Console.Write("y: ");
    double ay = GetValue("ay");
    Console.Write("z: ");
    double az = GetValue("az");
     Console.WriteLine("Point B coordinates:");
    Console.Write("x: ");
    double bx = GetValue("bx");
    Console.Write("y: ");
    double by = GetValue("by");
    Console.Write("z: ");
    double bz = GetValue("bz");

    double dis = GetDistance3D(ax, ay, az, bx, by, bz);
    Print(ax, ay, az, bx, by, bz, dis);
}

Distance3D();