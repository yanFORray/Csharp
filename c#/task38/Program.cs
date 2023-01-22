/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

*/

int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

double[] getGenerationOfArray(int count, int start, int end)
{
    double[] array = new double[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(start, end) + new Random().NextDouble();
    }
    return array;
}
void showResult(string message, double[] array, double maximum, double minimum, double decision)
{
    Console.Write(message);
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1)
        {
            Console.Write($"{Math.Round(array[i], 4)} ");
        }
        else
        {
             Console.WriteLine($"{Math.Round(array[i], 4)}] ");
        }
    }   
    Console.WriteLine($"Максимальный элемент равен: {Math.Round(maximum, 4)}");
    Console.WriteLine($"Минимальный элемент равен: {Math.Round(minimum, 4)}");
    Console.WriteLine($"Разность между максимальным и минимальным элементами массива равна: {Math.Round(decision, 4)}");
}
double getMaximumOrMinimumElement(double[] array, int key)
{
    double variable = array[0];   
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] * key > variable * key)
        {
            variable = array[i];
        }
    }
    return variable;
}
double subtractMinimumFromMaximum(double maxNumber, double minNumber)
{
    double result = maxNumber - minNumber;
    return result;
}
int length = getUserData("Введите размерность массива: ");
double[] generatedArray = getGenerationOfArray(length, -99, 99);
double maxElements = getMaximumOrMinimumElement(generatedArray, 1);
double minElements = getMaximumOrMinimumElement(generatedArray, -1);
double subtract = subtractMinimumFromMaximum(maxElements, minElements);
showResult("Сгенерированный массив: [", generatedArray, maxElements, minElements, subtract);