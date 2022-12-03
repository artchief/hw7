// **Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.**

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.Write("Введите кол-во столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во строк ");
int rows = Convert.ToInt32(Console.ReadLine());

double [,] matrix = new double[rows,columns];
var rnd = new Random();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
   
        // 1. Math.Round(... , 2) - это сколько  после запятой будет цифр
        // 2. var rnd = new Random(); - это рандом на минусовые числа с запятой
        //    (double)Convert.ToDouble((rnd).Next(-100,100)/10.0) 
        matrix[i,j] =  Math.Round((double)Convert.ToDouble((rnd).Next(-100,100)/10.0),2);
        Console.Write(matrix[i,j]+" ");


    
    }
    Console.WriteLine();
}