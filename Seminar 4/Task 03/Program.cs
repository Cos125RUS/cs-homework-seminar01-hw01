// Напишите метод, который задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int [8];
int size = Random.Shared.Next(1,9);

void CreatingAnArray(int[] array, int n)
{
    for (int i = 0; i < n; i++)
    {
        array[i] = Random.Shared.Next(1,20);        
    }

    var list = array.ToList();
    var resultList = list.GetRange(0, n);

    System.Console.Write(String.Join(", ", resultList));
    Console.Write(" -> [");
    System.Console.Write(String.Join(", ", resultList));
    Console.Write("]");
}

CreatingAnArray(array, size);