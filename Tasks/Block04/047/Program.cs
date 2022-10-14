// Написать программу копирования массива

void NewArray(int[] array, int n)
{
    for (int i = 0; i < n; i++)
    {
        array[i] = Random.Shared.Next(1, 100);
    }
}

int[] Copy(int[] array, int n)
{
    int[] copyArray = new int[n];
    for (int i = 0; i < n; i++)
    {
        copyArray[i] = array[i];
    }
    return copyArray;
}

int size = Random.Shared.Next(1, 20);
int[] array = new int[size];

NewArray(array, size);
System.Console.WriteLine(string.Join(' ', array));

int[] copyArray = Copy(array, size);
// Copy(array, copyArray, size);
System.Console.WriteLine(string.Join(' ', copyArray));