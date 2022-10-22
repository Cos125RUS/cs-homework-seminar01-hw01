// В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
// Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита


// 4^n вариантов
void TheWords(char[] alphabet, int n, int size, char[] word)
{
    if (n == 0)
    {
        System.Console.Write(String.Join("", word));
        Console.Write(' ');
    }
    else
    {
        for (int i = 0; i < size; i++)
        {
            word[n - 1] = alphabet[i];
            TheWords(alphabet, n - 1, size, word);
        }
    }
}

const int size = 4;
char[] machineAlphabet = { 'а', 'и', 'с', 'в' };

Console.Write("n = ");
int length = Convert.ToInt32(Console.ReadLine());

char[] word = new char[length];

TheWords(machineAlphabet, length, size, word);