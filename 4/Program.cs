// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
// 34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)

int length = 2; int width = 2; int depth = 2;

int [,,] arr = CreateArray(length, width, depth, 10, 17);
PrintArray(arr);

int [,,] CreateArray(int columns,int rows, int plane, int min, int max)
{
    int[,,] array = new int[plane, rows, columns];
    bool[] contains = new bool[max - min + 1];
    for (int z = 0; z < array.GetLength(0); z++)
        for (int y = 0; y < array.GetLength(1); y++)
            for (int x = 0; x < array.GetLength(2); x++)
            {
                bool repeat;
                do
                {
                    repeat = false;
                    array[z,y,x] = new Random().Next(min, max + 1);
                    if (contains[array[z,y,x] - min]) repeat = true;
                    else contains[array[z,y,x] - min] = true;
                } while (repeat);
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

//int [,,] CreateArray(int columns,int rows, int plane, int min, int max)
// {
//     int[,,] array = new int[plane, rows, columns];
//     for (int z = 0; z < array.GetLength(0); z++)
//         for (int y = 0; y < array.GetLength(1); y++)
//             for (int x = 0; x < array.GetLength(2); x++)
//             {
//                 bool contains;
//                 do
//                 {
//                     array[z,y,x] = new Random().Next(min, max + 1);
//                     contains = false;
//                     for (int i = 0; i < array.GetLength(0); i++)
//                         for (int j = 0; j < array.GetLength(1); j++)
//                             for (int k = 0; k < array.GetLength(2); k++)
//                             {
//                                 if (array[i,j,k] == array[z,y,x]) contains = true;
//                                 if (z == i && y == j && x == k) contains = false;
//                             }
//                 } while (contains);
//             }
//     return array;
// }