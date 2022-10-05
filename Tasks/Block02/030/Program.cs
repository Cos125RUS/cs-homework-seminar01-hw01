// Показать кубы чисел, заканчивающихся на четную цифру

Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());

double[] cube = new double[n];

for (int i = 0; i < n; i++)
{
    cube[i] = Math.Pow((i + 1), 3);
    if (cube[i]%10%2==0) Console.WriteLine((i+1)+"^3 = " + cube[i]);
}
