/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же 
указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
// Т.к приер не соответствует условию, на занятии договорились, что 
// проверяем значение и выводим позицию если есть и сообщение если нет.

int[,] GetArray(int m, int n, int minValue, int maxValue) 
{
    int[,] result = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = rand.Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
void IsExist (int[,] inArray, int x)
{
   bool result = false;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i,j]==x)
            {
                result = true;
                Console.WriteLine("("+i+"; "+j+")");
                break;
            } 
        
        }
        
    }
if (!result) Console.WriteLine("Такого числа в массиве нет");
}

Console.Clear();
Console.Write("Введите кол-во строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов массива: ");
int cols = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, cols, 0, 10);
PrintArray(array);
Console.Write("Введите число: ");
int value = int.Parse(Console.ReadLine()!);
IsExist(array,value);
