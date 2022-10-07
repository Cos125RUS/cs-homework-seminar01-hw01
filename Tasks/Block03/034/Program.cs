// Написать программу замену элементов массива на противоположные

int size = 12;
int[] array = new int[size];

for (int i = 0; i < size; i++)
{
    array[i] = Random.Shared.Next(0, 9);
    Console.Write(array[i] + "  ");    
}

Console.WriteLine();

for (int i = 0; i < size; i++)
{    
    array[i] *= -1;    
    Console.Write(array[i] + " ");   
}