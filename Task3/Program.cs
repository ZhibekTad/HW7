// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] PrintArray(int m, int n)
{
    int[,] array = new int [m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}

int m = Prompt("Введите количество строк: ");
int n = Prompt("Введите количество столбцов: ");
Console.WriteLine();

PrintArray(m, n);

int[,] aveNum = new int[m, n];;
for (int j = 0; j < aveNum.GetLength(1); j++)
{
   double average = 0;
   for (int i = 0; i < aveNum.GetLength(0); i++)
    {
        average = (average + aveNum[j, i]); // не пойму отчего не считает среднее
    }
   average = average / n;
   Console.Write(average + "; ");
}
Console.WriteLine();

