// В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
// Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита


// 4^n вариантов
string TheWords(char[] alphabet, int n, int size)
{
    // if (size > 0) TheWords (alphabet, n, size - 1);
    // if (size > 0)
    // {
    //     TheWords(alphabet, n, size - 1);

    //     for (int i = 0; i < n; i++)
    //     {
    //         Console.Write(alphabet[size - 1]);
    //     }
    //     Console.Write(' ');
    // }





    // for (int i = 0; i < n; i++)
    // {
    //     TheWords(alphabet, n - 1, size);
    //     Console.Write(alphabet[size - 1]);
    // }
    //     Console.Write(' ');



    // if (n == 0) Console.WriteLine(' ');
    // else
    // {
    //     Console.Write(alphabet[size - 1]);
    //     TheWords(alphabet, n - 1, size);
    // }



    // if (size > 0)
    // {
    //     TheWords(alphabet, n, size - 1);

    //     for (int i = 0; i < n; i++)
    //     {
    //         Console.Write(alphabet[size - 1]);
    //     }
    //     Console.Write(' ');
    // }
}

string[] DrawingUpTheAlphabet(char[] words, int length, int alphabetSize, int arraySize)
{
    string [] dictionary = new string[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        dictionary[i] = TheWords()
    }
}

int size = 4;
char[] machineAlphabet = { 'а', 'и', 'с', 'в' };

Console.Write("n = ");
int length = Convert.ToInt32(Console.ReadLine());

// TheWords(machineAlphabet, length, size);

double arraySize = Math.Pow(size, n);
string [] dictionary = DrawingUpTheAlphabet(machineAlphabet, length, size, arraySize);

