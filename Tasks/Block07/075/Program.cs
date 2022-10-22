double[] TransformToDecimal(int[] data, int[] info)
{
    int size = info.Length;
    double[] decimalNumber = new double[size];

    int start = 0;
    for (int i = 0; i < size; i++)
    {
        decimalNumber[i] = Math.Pow(2, info[i]) - 1;
        for (int j = 0; j < info[i]; j++)
        {
            if (data[start + j] == 0)
                decimalNumber[i] -= Math.Pow(2, info[i] - 1 - j);
        }

        start += info[i];
    }

    return decimalNumber;
}


int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };

double[] decimalNumber = TransformToDecimal(data, info);

System.Console.WriteLine(String.Join(", ", decimalNumber));