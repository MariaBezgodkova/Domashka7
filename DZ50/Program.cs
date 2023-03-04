// Напишите программу, которая на вход принимает позиции элемента
//  в двумерном массиве, и возвращает значение этого элемента или же указание,
//  что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
            matr[i, j] = new Random().Next(10, 20);
        }
    }
}
// метод для поиска нужного числа в массиве
void FindElement(int[,] matr, int find) //в качестве аргумента будет приходить наш массив matr
                                        // и некий аргумент find
                                        //string result = ""; 
                                                                             
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] == find)
            {
                Console.WriteLine($"Искомый элемент стоит на позиции {i} ; {j} ");
            }
            else Console.WriteLine("Нет такого");
           
        }
    }
  
}
int[,] matrix = new int[3, 4];
int find = 15;  // будем искать в массиве это число
FillArray(matrix);
PrintArray(matrix);
FindElement(matrix, find);
