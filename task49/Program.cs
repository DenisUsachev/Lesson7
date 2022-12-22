/*Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
*/

int[,] arr ={
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

var dim0 = arr.GetLength(0);
var dim1 = arr.GetLength(1);

for (int i = 0; i < dim0; i++)
{
    for (int i = 0; i < dim1; i++)
    {
        if (((i + 1) % 2) == 0 && ((j + 1) % 2) == 0)
        {
            arr[i,j] *= arr[i,j];
        }
    }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}


int rows = GetNumber("Введите количество строк: ");
int columns = GetNumber("Введите количество столбцов: ");
int[,] matrix = InitMatrix(rows, columns);
PrintMatrix(matrix);