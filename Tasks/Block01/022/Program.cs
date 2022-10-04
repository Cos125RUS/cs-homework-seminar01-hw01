// Найти расстояние между точками в пространстве 2D/3D
void Distance2D()
{
    double GetValue(string text)
    {
        //Console.Write(text + ": ");
        double value = Random.Shared.Next(1, 10);//Convert.ToDouble(Console.ReadLine());
        return value;
    }

    void Print(double ax, double ay, double bx, double by, double result)
    {
        string output = "|A(" + ax + ", " + ay + "); B(" + bx + ", " + by + ")| = " + result;
        //double r = Math.Rounds(result, 2); 
        //string output = $"|A({ax},{ay}; B({bx},{by}| = {r}";
        Console.WriteLine(output);
    }

    double GetDistance2D(double ax, double ay, double bx, double by)
    {
        double x = Math.Pow(ax - bx, 2);
        double y = Math.Pow(ay - by, 2);
        double result = Math.Sqrt(x + y);
        return result;
    }

    //System.Console.WriteLine(GetDistance(0,0,0,10));
    //Print (1,2,3,4);


    double ax = GetValue("ax");
    double ay = GetValue("ay");
    double bx = GetValue("bx");
    double by = GetValue("by");

    double dis = GetDistance2D(ax, ay, bx, by);
    Print(ax, ay, bx, by, dis);
}

void Distance3D()
{
    double GetValue(string text)
    {
        double value = Random.Shared.Next(1, 10);
        return value;
    }

    void Print(double ax, double ay, double az, double bx, double by, double bz, double result)
    {
        string output = "|A(" + ax + ", " + ay + ", "+az+"); B(" + bx + ", " + by + ", "+bz+");| = " + result;
        Console.WriteLine(output);
    }

    double GetDistance3D(double ax, double ay, double az, double bx, double by, double bz)
    {
        double x = Math.Pow(ax - bx, 2);
        double y = Math.Pow(ay - by, 2);
        double z = Math.Pow(az - bz, 2);
        double result = Math.Sqrt(x + y + z);
        return result;
    }

    double ax = GetValue("ax");
    double ay = GetValue("ay");
    double az = GetValue("az");
    double bx = GetValue("bx");
    double by = GetValue("by");
    double bz = GetValue("bz");

    double dis = GetDistance3D(ax, ay, az, bx, by, bz);
    Print(ax, ay, az, bx, by, bz, dis);
}

Distance2D();
Distance3D();