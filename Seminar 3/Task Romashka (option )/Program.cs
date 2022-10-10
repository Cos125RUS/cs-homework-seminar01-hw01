int[] Clients()
{
    int[] shop = new int[24];
    int counter = 0;
    string client;

    Console.WriteLine("Введите временной промежуток для следующего клиента. Для окончания ввода введите (end)");
    do
    {
        client = Console.ReadLine();
        if (client != "end")
        {
            var pos = client.IndexOf('-');
            int start = Convert.ToInt32(client.Substring(0, pos));
            int end = Convert.ToInt32(client.Substring(pos + 1));
            counter++;
            for (int i = start; i < end; i++)
            {
                ++shop[i];
            }
        }
    } while (client != "end");

    //System.Console.WriteLine(String.Join(' ', shop));

    return shop;
}


void MaxTime(int[] shop)
{
    int max = 0;

    for (int i = 0; i < 24; i++)
    {
        if (shop[i] >= max)
        {
            max = shop[i];            
        }
    }

    Console.Write("Максимальная загруженность: ");

    for (int i = 0; i < 24; i++)
    {
        if (max == shop[i])
        {
            int j = i;
            while (shop[j] == shop[j+1])
            {
                j++;
            }
            Console.Write(i + "-" + (j + 1) + "   ");
            i = j;
        }
    }
}

int[] shop = Clients();
MaxTime(shop);