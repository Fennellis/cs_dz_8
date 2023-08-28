// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int m = 5; int n = 15;

int[,] arr = CreateArray(m, n);
PrintArray(arr);

int[,] CreateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    FillArray(array, 1, 0, 1);  // Имя массива, начальное значение, начальный круг = 0 (внешний), начальное направление = 1 (вправо)
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],5}");
        Console.WriteLine();
    }
}

void FillArray(int[,] array, int count, int round, int toggle)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    switch (toggle)
    {
        case 1:
            for (int i = round; i < columns - 1 - round; i++)
            {
                array[round, i] = count;
                count++;
                if (count > columns * rows) return;
            }
            toggle = 2;
            break;
        case 2:
            for (int i = round; i < rows - 1 - round; i++)
            {
                array[i, columns - 1 - round] = count;
                count++;
                if (count > columns * rows) return;
            }
            toggle = 3;
            break;
        case 3:
            for (int i = columns - 1 - round; i > round; i--)
            {
                array[rows - 1 - round, i] = count;
                count++;
                if (count > columns * rows) return;
            }
            toggle = 4;
            break;
        case 4:
            for (int i = rows - 1 - round; i > round; i--)
            {
                array[i, round] = count;
                count++;
                if (count > columns * rows) return;
            }
            toggle = 1;
            round++;
            break;
    }
    FillArray(array, count, round, toggle);
}

// // 1 round

    // for (int i = 0; i < columns - 1; i++)
    // {
    //     array[0, i] = k;
    //     k++;
    // }

    // for (int i = 0; i < rows - 1; i++)
    // {
    //     array[i, columns - 1] = k;
    //     k++;
    // }

    // for (int i = columns - 1; i > 0; i--)
    // {
    //    array[rows - 1, i] = k;
    //    k++; 
    // }

    // for (int i = rows - 1; i > 0; i--)
    // {
    //     array[i, 0] = k;
    //     k++;
    // }

// // 2 round

    // for (int i = 1; i < columns - 2; i++)
    // {
    //     array[1, i] = k;
    //     k++;
    // }

    // for (int i = 1; i < rows - 2; i++)
    // {
    //     array[i, columns - 2] = k;
    //     k++;
    // }

    // for (int i = columns - 2; i > 1; i--)
    // {
    //    array[rows - 2, i] = k;
    //    k++; 
    // }

    // for (int i = rows - 2; i > 1; i--)
    // {
    //     array[i, 1] = k;
    //     k++;
    // }