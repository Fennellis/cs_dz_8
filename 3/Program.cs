// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк 1 матрицы: ");
int m1 = Int32.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов 1 матрицы: ");
int n1 = Int32.Parse(Console.ReadLine()!);
Console.Write("Введите количество строк 2 матрицы: ");
int m2 = Int32.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов 2 матрицы: ");
int n2 = Int32.Parse(Console.ReadLine()!);
Console.WriteLine();

int[,] matrix1 = CreateArray(m1,n1,-5,10);
Console.WriteLine("Первая матрица:");
PrintArray(matrix1);
Console.WriteLine();
Console.WriteLine("Вторая матрица:");
int[,] matrix2 = CreateArray(m2,n2,-10,20);
PrintArray(matrix2);

if(n1 == m2)
{
    int[,] newMatrix = MatrixMult(matrix1, matrix2);
    Console.WriteLine("Результатная матрица:");
    PrintArray(newMatrix);
}
else Console.WriteLine("Не удалось выполнить умножение");


int [,] CreateArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(min, max + 1);
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j], 5}");
        Console.WriteLine();
    }
}

int[,] MatrixMult(int[,] firstMatrix, int [,] secondMatrix)
{
    int[,] resultMatrix = new int[firstMatrix.GetLength(0),secondMatrix.GetLength(1)];
    int sum = 0;
    for(int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            for(int m = 0; m < resultMatrix.GetLength(0); m++)
            {
                sum += firstMatrix[i,m] * secondMatrix[m,j];
            }
            resultMatrix[i,j] = sum;
            sum = 0;
        }
    }
    return resultMatrix;
}