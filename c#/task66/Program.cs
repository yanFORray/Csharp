/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.Clear();
int getDataFromUser(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int printRange(int numberM, int numberN)
{
    if (numberM == numberN)
    {

        return numberM;
    }
    return numberM + printRange(numberM + 1, numberN);
}

int numberM = getDataFromUser("Введите число M");
int numberN = getDataFromUser("Введите число N");
int result = printRange(numberM, numberN);
Console.WriteLine(result);