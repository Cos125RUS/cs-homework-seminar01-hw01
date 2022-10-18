const int s = 123;

int[] Counting(string text, int size)
{
    int[] freq = new int[s];
    for (int i = 0; i < size; i++)
    {
        ++freq[Convert.ToInt32(text[i])];
    }
    return freq;
}

void FrequencyAnalysis(int[] order, int[] pos, int count, int size)
{
    char symbol;
    double f;

    for (int i = 0; i < count; i++)
    {
        f = order[i];
        symbol = Convert.ToChar(pos[i]);
        System.Console.WriteLine($"Symbol {symbol} met in text {order[i]} times. Frequency is {f / size * 100}%");
    }
}

(int[], int[], int) Sorting(int[] freq)
{
    int count = 0;
    for (int i = 0; i < s; i++)
    {
        if (freq[i] > 0) count++;
    }

    int[] order = new int[count];
    int[] position = new int[count];
    count = 0;

    for (int i = 0; i < s; i++)
    {
        if (freq[i] > 0)
        {
            order[count] = freq[i];
            position[count] = i;
            count++;
        }
    }

    for (int i = 0; i < count - 1; i++)
    {
        int min = 0,
            m = 0;

        for (int j = 0; j < count - 1 - i; j++)
        {
            if (order[j] < order[j + 1])
            {
                min = order[j];
                m = position[j];
                order[j] = order[j + 1];
                position[j] = position[j + 1];
                order[j + 1] = min;
                position[j + 1] = m;
            }
        }
    }

    return (order, position, count);
}


string text = Console.ReadLine();
text = text.ToLower();

int size = text.Length;

int[] freq = Counting(text, size);

(int[] order, int[] pos, int count) = Sorting(freq);

FrequencyAnalysis( order, pos, count, size);