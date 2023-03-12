// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// Console.Write("Введите количество столбцов: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество строк: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] tab = new int[n, m];
// void FillArray(int[,] con)
// System.Console.WriteLine("Введите количество строк массива ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов массива ");
// int n = Convert.ToInt32(Console.ReadLine();
// Console.WriteLine();

//  FillArray(table);
// {
//     for (int rows = 0; rows < con.GetLength(0); rows++)
//     {
//         for (int columns = 0; columns < con.GetLength(1); columns++)
//         {
//             con[rows, columns] = new Random().Next(1, 10);
//             Console.Write($"{con[rows, columns],3}");
//         }
//         Console.WriteLine();
//     }
// }





int Prompt(string massege)
{
    System.Console.Write(massege);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


int[,] CreaateArray(int m = 3, int n = 4)
{
    int[,] array = new int[m, n];
    return array;
}


void PrintArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j],4} ");
        }
        System.Console.WriteLine();
    }
}


int[,] FillArrayRandom(int[,] coll)
{
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            coll[i, j] = new Random().Next(-9, 10);
        }
    }
    return coll;
}

int[,] SortRows(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    (arr[i, k], arr[i, k + 1]) = (arr[i, k + 1], arr[i, k]);
                }
            }
        }
    }
    return arr;
}


void Main()
{
    int[,] arr = CreaateArray();
    arr = FillArrayRandom(arr);
    PrintArr(arr);
    System.Console.WriteLine("\nsort: ");
    PrintArr(SortRows(arr));
}

Main();