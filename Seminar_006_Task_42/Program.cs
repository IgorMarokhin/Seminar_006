// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

Console.Clear();
int num = GetNumberFromUser("Введите целое число: ","Ошибка ввода!");
string decimalNum = CreateDecimalNum();
Console.WriteLine($"{decimalNum}");

/////////////////////////////////////////////

int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)
            return userNumber;
    Console.WriteLine(errorMessage);
    }
}

string CreateDecimalNum()
{
    int userNumber = num;
    string result = String.Empty;
    if (num == 0) return "0";
    while (num > 0)
    {
        result = (num % 2).ToString() + result;
        num = num/2;
    }
    return result;
}