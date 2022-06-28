// SNACK 12
{
    bool isEven(int num)
    {
        if(num % 2 == 0)
        {
            return true;
        }

        return false;
    }

    Console.Write("\nInsert a number: ");
    int num = Convert.ToInt32(Console.ReadLine());

    Console.Write($"\nNumber {num} is ");
    if (isEven(num))
    {
        Console.Write("even\n");
    }
    else
    {
        Console.Write("odd\n");
    }

    return;
}


// SNACK 11
{
    string GetWord()
    {
        Console.Write("\nInsert a word: ");
        string word = Console.ReadLine();
        return word;
    }

    void checkWordsLenght(string word1, string word2)
    {
        if(word1.Length == word2.Length)
        {
            Console.WriteLine($"\n{word1}, {word2}");
        }
        else if(word1.Length > word2.Length)
        {
            Console.WriteLine($"\n{word1}");
        }
        else
        {
            Console.WriteLine($"\n{word2}");
        }
    }

    checkWordsLenght(GetWord(), GetWord());

    return;
}


// SNACK 10
{
    Console.WriteLine($"\nInsert a number: ");
    int N = Convert.ToInt32(Console.ReadLine());

    Random rnd = new Random();

    for (int i = 0; i < N; i++)
    {
        int[] array = new int[10];

        for (int j = 0; j < array.Length; j++)
        {
            array[j] = rnd.Next(1, 101);
        }

        // Stampa array
        Console.Write($"\nArray {i+1}: [");
        for (int j = 0; j < array.Length; j++)
        {
            Console.Write($"{array[j]}");
            if(j < array.Length - 1)
            {
                Console.Write(", ");
            }   
        }
        Console.Write("]");
    }

    Console.WriteLine();

    return;
}


// SNACK 5
{
    Console.WriteLine("\n*** SNACK 5 *** ");

    Console.WriteLine($"\nInsert a number: ");
    int input = Convert.ToInt32(Console.ReadLine());

    Console.Write("\nResult: ");

    if (input % 2 == 0)
    {
        Console.Write(input);
    }
    else
    {
        Console.Write(input+1);
    }

    Console.WriteLine();

    return;
}


// SNACK 4
{
    Console.WriteLine("\n*** SNACK 4 *** ");

    int min = 2;
    int max = 10;

    float average;
    int sum = 0;

    for (int i = min; i <= max; i++)
    {
        sum += i;
    }

    average = (float)sum / (max - min + 1);

    Console.WriteLine($"\nNumbers from {min} to {max}");
    Console.WriteLine($"\nSum: {sum}");
    Console.WriteLine($"Average: {average}");

    return;
}



// SNACK 3
{
    Console.WriteLine("\n*** SNACK 3 *** ");

    int inputNum = 10;  // numero di input richesti all'utente
    int[] array = new int[inputNum]; // array che salva gli input dell'utente
    int sum = 0;

    Console.WriteLine($"\nInsert {inputNum} integer numbers.");

    for (int i = 0; i < array.Length; i++)
    {
        // si potrebbe aggiungere un controllo per verificare che l'input inserito sia nel formato richiesto
        array[i] = Convert.ToInt32(Console.ReadLine());
        sum += array[i];
    }

    Console.WriteLine($"\nSum: {sum}");
}

