// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine ("Введите длину массива: ");
int count = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[count];

void Arraynumbers()
{
    Console.WriteLine("Введите число массива: ");
    for (int i = 0; i < count; i++)
    {
        if (i > 0)
        {
            Console.WriteLine("Введите число массива: ");
        }
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int SumPositive()
{
    int sum = 0;
    for (int i = 0; i < count; i++)
    {
        if (arr[i] > 0)
        {
            sum ++;
        }
    }
    return sum;
}

Arraynumbers();
Console.WriteLine($"Числа массива [{string.Join("; ", arr)}], Положительных чисел: {SumPositive()}");