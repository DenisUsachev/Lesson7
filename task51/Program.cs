/*Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12*/


int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        if(int.TryParse(Console.ReadLine(),  out result) && result > 0) 
        {
            break;
        }
        else 
        {
            Console.WriteLine("Ввели не число. Ввели некорректное число");    
        }
    }
    return result;
}


int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int SumDiagonalElements(int[,] matrix)
{
    int sum = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i,j];
    }
    return sum;
}



int rows = GetNumber("Введите количество строк: ");
int columns = GetNumber("Введите количество столбцов: ");

if(rows == columns)
{
    int[,] matrix = InitMatrix(rows, columns);
    PrintMatrix(matrix);
    int sum = SumDiagonalElements(matrix);
    Console.WriteLine(sum);
}
else
{
    Console.WriteLine("Матрица не квадратная");
}