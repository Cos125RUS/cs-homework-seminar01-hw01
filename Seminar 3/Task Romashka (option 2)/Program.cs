void Counter(int[] romashka, int peaples)
{
    for (int i = 0; i < peaples; i++)
    {
        int coming, care;

        do
        {
            Console.Write((i + 1) + " man come: ");
            coming = Convert.ToInt32(Console.ReadLine());
            if (coming <= 0 || coming > 23) Console.WriteLine("Wrong time");
        } while (coming <= 0 || coming > 23);

        do
        {
            Console.Write((i + 1) + " man out: ");
            care = Convert.ToInt32(Console.ReadLine());
            if (care < 0 || care > 23) Console.WriteLine("Wrong time");
        } while (care < coming || care > 23);

        for (int j = coming; j < care; j++)
        {
            ++romashka[j];
        }
    }
    //System.Console.WriteLine(String.Join(' ', romashka));
}

void MaxTime(int[] romashka)
{
    int max = 0;

    for (int i = 0; i < 24; i++)
    {
        if (romashka[i] >= max)
        {
            max = romashka[i];
        }
    }
    for (int i = 0; i < 24; i++)
    {
        if (max == romashka[i])
        {
            Console.WriteLine("Maximum workload: " + i + "-" + (i + 1));
        }
    }
}




Console.Write("Peaples today - ");
int peaples = Convert.ToInt32(Console.ReadLine());
int[] romashka = new int[24];

Counter(romashka, peaples);
MaxTime(romashka);