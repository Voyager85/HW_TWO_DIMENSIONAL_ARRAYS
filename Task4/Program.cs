// Задача 4*(не обязательная):
// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива.
// Под удалением понимается создание нового двумерного массива без строки и столбца

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[] minElementPos(int[,] array, int[] index)
{
    int minElement = 11;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (minElement > array[i, j])
            {
                minElement = array[i, j];
                index[0] = i;
                index[1] = j;
            }
        }

    }
    return index;
}

// Задаем размерность массива
int rows = 4;
int cols = 5;

// Создаем массив
int[,] array = new int[rows, cols];
int[] index = { 0, 0 };
// Заполняем случайными значениями от 1 до 10
FillArray(array);
// выводим на экран
System.Console.WriteLine("Задан массив:");
PrintArray(array);
minElementPos(array, index);
System.Console.WriteLine($"Первый наименьший элемент находится по адресу: {index[0]}, {index[1]}");
// Удаляем эти строку и столбец
// Создаем новый массив с меньшим количеством строк и столбцов на 1
int[,] DeleteCross(int[,] array, int row, int col)
{
    int[,] new_array = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0; i < new_array.GetLength(0); i++)
    {
        int a = i >= row ? i + 1 : i;
        for (int j = 0; j < new_array.GetLength(1); j++)
        {
            int b = j >= col ? j + 1 : j;
            new_array[i, j] = array[a, b];
        }
    }
    return new_array;
}
System.Console.WriteLine("Новый массив без строки и столбца, на пересечении которых расположен наименьший элемент массива ");
PrintArray(DeleteCross(array, index[0], index[1]));