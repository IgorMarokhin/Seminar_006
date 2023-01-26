// // Задача 41.  Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
//
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 3

Console.Clear();

int M = GetElementsFromUser("Введите количество элементов массива: ", "Ошибка ввода!");
int[] array = ArrayFromUser();
int col = SumPositiveNumbers(array);
Console.WriteLine($"{String.Join(", ", array)} -> {col}");

/////////////////////////////////////////////

int GetElementsFromUser(string message, string errorMessage)
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

int[] ArrayFromUser()
{
    int [] array = new int[M];
    for (int i = 0; i < M; i++)
    {
        Console.Write("Введите целое число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int SumPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}