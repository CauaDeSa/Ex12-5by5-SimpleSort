int size = 10, sizeAux = size, numbersAux;
int[] numbers = new int[size];
bool ordered = false;

for (int i = 0; i < size; i++)
{
    Console.Write($"Type the {i + 1}° number ");
    numbers[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("\n\nOrdering");

for (int i = 1; i < size; i++)
{
    if (i == 1)
        ordered = true;

    if (numbers[i] < numbers[i - 1])
    {
        numbersAux = numbers[i];
        numbers[i] = numbers[i - 1];
        numbers[i - 1] = numbersAux;
        ordered = false;
    }

    for (int j = 0; j < size; j++)
    {
        Console.Write($"{numbers[j]} ");
    }
    Console.WriteLine();

    if (i == size - 1 && !ordered)
    {

        i = 0;
        size--;
        Console.WriteLine("\n---------- The last is ordered ----------\n");
    }
}

Console.WriteLine("\n\nOrdered values");
size = sizeAux;

for (int i = 0; i < size; i++)
{
    Console.Write($"{numbers[i]} ");
}

Console.Write("Press any key to continue...");
Console.WriteLine();