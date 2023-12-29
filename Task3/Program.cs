// Задача 3:
// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0, 10);
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

int minRowSum(int[,] array)
{
    int minRowSum = 100;
    int tmpSum = 0;
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        tmpSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tmpSum += array[i,j];
        }
        if(minRowSum > tmpSum) {
            minRowSum = tmpSum;
            index = i;
        }
    }
    return index;
}

// Задаем размерность массива
int rows = 4;
int cols = 4;

// Создаем массив
int[,] array = new int[rows, cols];

// Заполняем случайными значениями от 1 до 10
FillArray(array);
// выводим на экран
PrintArray(array);

System.Console.WriteLine($"Индекс строки с наименьшей суммой элементов: {minRowSum(array)}");
