// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();

int b1 = GetNumberFromUser("Введите значение переменной b1: ", "Ошибка ввода!");
int k1 = GetNumberFromUser("Введите значение переменной k1: ", "Ошибка ввода!");
int b2 = GetNumberFromUser("Введите значение переменной b2: ", "Ошибка ввода!");
int k2 = GetNumberFromUser("Введите значение переменной k2: ", "Ошибка ввода!");
CrossPoint(b1, k1, b2, k2);

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

void CrossPoint(double b1, double k1, double b2, double k2)
{
    double x = (b1 - b2)/(k2 - k1);
    double y = (k2 * b1 - k1 * b2)/(k2 - k1);
    if (k1 == k2) Console.WriteLine("Прямые не пересекаются");
    else Console.WriteLine($"Точка пересечения прямых: ({x} {y})");
}