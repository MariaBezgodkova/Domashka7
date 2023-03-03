// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



void PrintArray(double[,] matr)  // метод для печати двумерного массива
{
    for (int i = 0; i < matr.GetLength(0); i++)  // GetLength(0) - чтобы не писать каждый раз кол-во строк
    {
        for (int j = 0; j < matr.GetLength(1); j++)  // GetLength(1) - чтобы не писать каждый раз кол-во столбцов
        {
            Console.Write($"{matr[i, j]} " + "\t");
        }
        Console.WriteLine();
    }
}
void FillArray(double[,] matr)// метод для заполнения матрицы случайными числами
{
    for (int i = 0; i < matr.GetLength(0); i++)  // GetLength(0) - возвращает кол-во строк
    {
        for (int j = 0; j < matr.GetLength(1); j++)  // GetLength(1) - возвращает кол-во столбцов
        {
            matr[i, j] =Math.Round (new Random().NextDouble()*20) ;// выводим рандомные вещественные
                                                                   // числа до 20, округленные до целых
          
        }
    }
}
Console.Write("Задайте кол-во строк в массиве m -");
int m = int.Parse(Console.ReadLine());
int[] array = new int[m];
Console.Write("Задайте кол-во столбцов в массиве n -");
int n = int.Parse(Console.ReadLine());
int[] array2 = new int[n];
double[,] matrix = new double[m, n];


FillArray(matrix);
PrintArray(matrix);