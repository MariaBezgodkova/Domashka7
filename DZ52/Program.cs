// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6;    5,6;    3,6;    3.
void PrintArray(int[,] matr)  // метод для печати двумерного массива
{
    for (int i = 0; i < matr.GetLength(0); i++)  //  по строкам
    {
        for (int j = 0; j < matr.GetLength(1); j++)//  по столбцам
        {
            Console.Write($"{matr[i, j]} " + "\t");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)// метод для заполнения матрицы случайными числами от 10 до 20
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 100);
        }
    }
}
void ArithmeticMeanElements (int[,] matr) // метод для поиска среднего арифметического в каждом столбце 
{
for (int j = 0; j < matr.GetLength(1); j++)  //  по строкам
{
    double summ = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        summ = summ+ matr[i, j];
    }
    Console.WriteLine($"Ср. арифм. эл-ов в {j} столбце - {Math.Round(summ/matr.GetLength(0),2)}");
}
}




int[,] matrix = new int[5, 5];
FillArray(matrix);
PrintArray(matrix);
ArithmeticMeanElements (matrix);




