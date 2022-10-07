// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int size = 8;
int[] array = new int[size];

for (int i = 0; i < size; i++)
{
    array[i] = Random.Shared.Next(0,2);
    Console.Write(array[i]+"  ");    
}
