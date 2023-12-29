// Задача 2:
// Задайте двумерный массив.
// Напишите программу, которая поменяет местами первую
// и последнюю строку массива.

// Объявляем двумерный массив типа string [4,5]:
int row_count = 4;
int col_count = 5;
string[,] str_array = new string[row_count, col_count];
char[] delimiterChars = { ' ', ',', '.', ':', ';', '-', '\n', '\t' };
// Из текстовой строки:
string str = "это популярный портал для проверки текстов и крупнейшая биржа текстового контента ежедневно на Сервисе проверяются и создаются разные форматы описания";
// Формируем двумерный массив:

void FillArray(string[,] str_array, string str)
{
    string[] tmpstr = str.Split(delimiterChars);
    int jtmp = 0;
    for (int i = 0; i < row_count; i++)
    {
        for (int j = 0; j < col_count; j++)
        {
            jtmp = (i * 5) + j;
            str_array[i, j] = tmpstr[jtmp];
        }
    }
}

void PrintArray(string[,] str_array)
{
    for (int i = 0; i < row_count; i++)
    {
        for (int j = 0; j < col_count; j++)
        {
            System.Console.Write(str_array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

System.Console.WriteLine("Задаем двумерный массив:\n");
FillArray(str_array, str);
PrintArray(str_array);

System.Console.WriteLine("\nМеняем местами первую и последнюю строку массива:\n");

string tempStringFirst, tempStringLast;

for (int j = 0; j < col_count; j++)
{
    tempStringFirst = str_array[0, j];
    tempStringLast = str_array[row_count-1 , j];
    str_array[0,j] = tempStringLast;
    str_array[row_count - 1,j] = tempStringFirst;
}

PrintArray(str_array);