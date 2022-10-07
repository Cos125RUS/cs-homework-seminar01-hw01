// Задать массив из 8 элементов и вывести их на экран

int size = 8;
int[] array = new int[size];

for (int i = 0; i < size; i++)
{
    array[i] = Random.Shared.Next(1,10);
    Console.Write(array[i]+"  ");    
}