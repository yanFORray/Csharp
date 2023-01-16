//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.




int getUserData(string messege)
{
    Console.WriteLine(messege);
    int userData = int.Parse(Console.ReadLine()!);    
    return userData;
}

int getDigitOfNumber(int reducedNumber)
{
    reducedNumber = reducedNumber % 10;
    return reducedNumber;
}

int getSumOfDigit(int A)
{  
    int sumDigit = 0;
    while (A > 0)
    {
        sumDigit = sumDigit + getDigitOfNumber(A);
        A = A / 10;
    }
    return sumDigit;
}

string getNumberInString(int userNumber)
{
    string numberStr = Convert.ToString(userNumber);
    string newNumberStr = String.Empty;
    for (int i = 0; i < numberStr.Length; i++)
    {
        newNumberStr = newNumberStr + numberStr[i];
        if (i != numberStr.Length - 1)
        {
            newNumberStr = newNumberStr + " + ";
        }
    } 
    return newNumberStr;
}

void showResult(string messege, int result)
{
    Console.WriteLine($"{messege} {result}");
}

int number = getUserData("Ваше число: ");
int sum = getSumOfDigit(number);
string numberString = getNumberInString(number);
showResult($"Сумма цифр вашего числа: {numberString} =", sum);
