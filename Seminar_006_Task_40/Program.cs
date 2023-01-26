// Задача 40. Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.Clear();

int[] array = new int[3];
GetArray(array);

bool result = CheckNumbers(array);

Console.WriteLine($"Треугольник со сторонами заданной длинны существует? {(result ? "да" : "нет")}");

////////////////////////////////////

void GetArray(int[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        while(true)
        {
            Console.Write($"Введите {i}-й элемент массива: ");
            bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
            if(isCorrect)
                {
                    newArray[i] = userNumber;
                    break;
                }
            else Console.WriteLine("Ошибка ввода!");
        }
    }
}

bool CheckNumbers(int[] arr)
{
    Console.WriteLine($"{String.Join(" ", arr)}");
    int size = arr.Length;
    if (arr[0] < (arr[1] + arr[2]) && arr[1] < (arr[2] + arr[0]) && arr[2] < (arr[1] + arr[0]))
        return true;
    else
        return false;
}