/*Пользователь вводит с клавиатуры N чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3

*/

Console.Clear();

int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

void enterNumber(string message, int number)
{
    string str = string.Empty;
    int count = 0;    
    for (int i = 0; i < number; i++)
    {
        Console.Write($"Введите число № {i + 1} : ");
        int enterNumber = int.Parse(Console.ReadLine()!);
        if (enterNumber > 0) 
            count++;
        if (i != number - 1) 
            str += Convert.ToString(enterNumber) + ", ";        
        else 
            str += Convert.ToString(enterNumber) + "]";      
    }  
    Console.WriteLine();
    Console.Write($"{message}{str} - ");
    Console.WriteLine($"{((count != 0)? $"количество чисел больше 0 равно {count}" : "числа больше 0 не вводили")}");
}

int numberUser = getUserData("Количество чисел, которое хотите ввести: ");
enterNumber($"В числах [", numberUser);