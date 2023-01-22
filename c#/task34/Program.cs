//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


Console.Clear();

int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

int[] getGenerationOfArray(int count, int start, int end)
{
    int[] array = new int[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}
void showResult(string messege, int[] array, int elements)
{
    Console.Write(messege);
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
             Console.Write($"{array[i]}] ");
        }
    }
    if (elements != 0)
    {
        Console.WriteLine($"- количество чётных чисел равно {elements}");
    }
    else
    {
        Console.WriteLine("- чётных чисел нет");
    }
}
int numberOfEvenElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
int length = getUserData("Сколько чисел в массиве?: ");
int[] generatedArray = getGenerationOfArray(length, 100, 998);
int evenElements = numberOfEvenElements(generatedArray);
showResult("В сгенерированном массиве [", generatedArray, evenElements);