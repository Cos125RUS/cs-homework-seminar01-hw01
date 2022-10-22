int[] TransformToDecimal(bool[] data, int[] size)
{
    int size = info.Length;
    int[] decimalNumber = new int[size];

    int end = 0;
    for (int i = 0; i < size; i++)
    {
        for (int j = end; j < info[i]; j++)
        {
            
        }

        end = info[i];
    }
}







bool[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };

int size = info.Length;
int[] decimalNumber = TransformToDecimal(data, info);

System.Console.WriteLine(String.Join(", ", decimalNumber));