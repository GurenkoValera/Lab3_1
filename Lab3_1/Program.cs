using System;

class Program
{
    static void Main()
    {
        // Запрос числа элементов массива
        Console.Write("Введите количество элементов массива: ");
        int size = int.Parse(Console.ReadLine());

        // Создание массива
        int[] array = new int[size];
        Random random = new Random();

        // Заполнение массива случайными целыми числами от -30 до 45
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(-30, 46); // 46 не включается, поэтому верхний предел 46
        }

        // Вывод массива строками по 10 элементов
        Console.WriteLine("\nЭлементы массива:");
        for (int i = 0; i < size; i++)
        {
            Console.Write(array[i] + "\t");
            if ((i + 1) % 10 == 0) // Каждые 10 элементов переносим строку
            {
                Console.WriteLine();
            }
        }

        // Вывод элементов массива в обратном порядке, игнорируя отрицательные элементы
        Console.WriteLine("\nЭлементы массива в обратном порядке (игнорируя отрицательные):");
        for (int i = size - 1; i >= 0; i--)
        {
            if (array[i] >= 0) // Проверка на неотрицательные элементы
            {
                Console.Write(array[i] + "\t");
            }
        }

        Console.WriteLine(); // Перенос строки в конце
    }
}