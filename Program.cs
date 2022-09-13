// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько
// чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write($"Введи число М (количество чисел): ");
int Numbers = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[Numbers]; // создание массива с определенным количеством

void InputNumbers(int Numbers) // заполнение массива
{
    for (int i = 0; i < Numbers; i++)
    {
        Console.Write($"Введи {i + 1} число: ");
        massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}


int UpZero(int[] massiveNumbers)
{
    int count = 0;
    for (int i = 0; i < massiveNumbers.Length; i++)
    {
        if (massiveNumbers[i] > 0) count += 1;
    }
    return count;
}

InputNumbers(Numbers);

Console.WriteLine($"Введено чисел больше 0: {UpZero(massiveNumbers)} ");