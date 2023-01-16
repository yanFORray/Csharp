// число А на вход  выводит сумму чисел от 1 до А
int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

int getSumOfRange(int start, int end)
{
    int sum = 0;
    for (int i = start; i <= end; i++)
    {
        sum += i;
    }
    return sum;
}
void showData(string messageStart, int data)
{
    Console.Write(messageStart);
    Console.Write(data);
}
int end = getUserData("Введите число А для получения суммы");
int sum = getSumOfRange(1,end);
showData($"сумма чисел от 1 до {end} = ",sum );