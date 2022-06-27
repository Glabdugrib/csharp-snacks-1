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

