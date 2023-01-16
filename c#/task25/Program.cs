//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}
int powForNumber(int yourNumber, int index)
{
    int total = 1;
    for (int i = 0; i < index; i++)
    {
        total = total * yourNumber;
    }
    return total;
}
void showResult(string message, int result)
{    
    Console.WriteLine($"{message} {result}");
}
int number = getUserData("Какое число будем возводить в степень? ");
int degree = getUserData($"Число {number} в какую степень возводим? ");
int degreeNumber = powForNumber(number, degree);
showResult($"Ответ: {number} ^ {degree} =", degreeNumber);