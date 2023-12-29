// Задача 1:
// Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или
// же указание, что такого элемента нет.

// Объявляем одномерный массив координат (строка, столбец)
int[] posArr = { 0, 0 };

// Объявляем двумерный массив целых чисел 4 строки, 5 столбцов
int[,] myArr = new int[4, 5];

void FillArray(int[,] myArr)
{
    Random ran = new Random();

    System.Console.WriteLine("Задан двумерный массив:");

    // Инициализируем данный массив
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            myArr[i, j] = ran.Next(1, 15);
            Console.Write("{0}\t", myArr[i, j]);
        }
        Console.WriteLine();
    }
}


int ParseInputString(string inputString)
{
    char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
    string[] position = inputString.Split(delimiterChars);

    if (position[0] == "q")
    {
        return 0;
    }

    int z = 0;
    foreach (var value in position)
    {
        if (z > 1)
        {
            Console.WriteLine("ОШИБКА ВВОДА: введено более двух значений");
            return -1;
        }
        bool success = int.TryParse(value, out posArr[z++]);
        if (!success)
        {
            Console.WriteLine($"ОШИБКА ВВОДА: Позиция '{value ?? "<null>"}'.");
            return -1;
        }
    }
    System.Console.WriteLine("Задана позиция: " + posArr[0] + "," + posArr[1]);

    if (posArr[0] > myArr.GetLength(0) - 1 || posArr[1] > myArr.GetLength(1) - 1 || posArr[0] < 0 || posArr[1] < 0)
    {
        System.Console.WriteLine("ОШИБКА: Вы указали недопустимый адрес ячейки массива");
        return -1;
    }
    return 1;
}


//Заполняем двумерный массив случайными значениями
FillArray(myArr);

int res = 1;
while (res != 0)
{
    System.Console.WriteLine("\nЗадайте адрес ячейки двумерного массива (начальный адрес <0,0>) в виде <1><разделитель><2>, для завершения введите <q> : ");
    System.Console.WriteLine("Допустимые симвлоы разделителя: ' ', ',', '.', ':', 'tab' ");
    string inputString = Console.ReadLine();

    // Разбираем строку ввода и выводим значение в массиве по его координатам
    res = ParseInputString(inputString);
    if (res == 1)
    {
        System.Console.WriteLine("Значение массива = " + myArr[posArr[0], posArr[1]]);
    }
}
System.Console.WriteLine("Завершение работы.");




