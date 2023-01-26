// Задача 44. Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
//
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Clear();
int N = GetNumberFromUser("Введите целое число, которое больше, чем число 2: ","Ошибка ввода!");
int[] array = Fibonacсi(N);
Console.WriteLine($"Если N = {N} -> {String.Join(", ", array)}");

/////////////////////////////////////////////

int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect && userNumber != 0 && userNumber != 1 && userNumber != 2)
            return userNumber;
    Console.WriteLine(errorMessage);
    }
}

int[] Fibonacсi(int N)
{
    int[] result = new int[N];
    result[0] = 0;
    result[1] = 1;
    for (int i = 2; i < N; i++)
    {
       result[i] = result[i - 1] + result[i - 2];
    }
    return result;
}