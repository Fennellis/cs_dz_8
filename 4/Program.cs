// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
// 34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)

int length = 5; int width = 5; int depth = 5;

int [,,] arr = CreateArray(length, width, depth, 10, 99);
PrintArray(arr);

int [,,] CreateArray(int columns,int rows, int plane, int min, int max)
{
    int[,,] array = new int[plane, rows, columns];
    for (int z = 0; z < array.GetLength(0); z++)
        for (int y = 0; y < array.GetLength(1); y++)
            for (int x = 0; x < array.GetLength(2); x++)
            {
                bool contains;
                do
                {
                    array[z,y,x] = new Random().Next(min, max + 1);
                    contains = false;
                    for (int i = 0; i <= z; i++)
                        for (int j = 0; j <= y; j++)
                            for (int k = 0; k < x; k++)
                            {
                                if (array[i,j,k] == array[z,y,x]) contains = true;
                            }
                } while (contains);
            }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int z = 0; z < array.GetLength(0); z++)
    {
       for (int y = 0; y < array.GetLength(1); y++)
       {
        for (int x = 0; x < array.GetLength(2); x++)
            {
                Console.Write($"{array[z,y,x], 4}({z},{y},{x})  ");
            } 
       }
       Console.WriteLine();
    }
}