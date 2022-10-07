// Определить, присутствует ли в заданном массиве, некоторое число

int size = 12,
    num = Random.Shared.Next(0, 9);    
int[] array = new int[size];
bool find = false;

for (int i = 0; i < size; i++)
{
    array[i] = Random.Shared.Next(0, 9);
    Console.Write(array[i] + "  "); 
    if (array[i] == num) find = true;
}

Console.WriteLine();

if (find == true) Console.WriteLine("The number " +num+" is present in the array");
else Console.WriteLine("The number " +num+" is not present in the array");
