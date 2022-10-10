// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[, ] matrix = new int[n, m];

InputMatrix(matrix);
PrintMatrix(matrix);
PrintMatrix(ReleaseMatrix(matrix));

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11);      
    }
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + " \t");
        Console.WriteLine();      
    }
}

int[,] ReleaseMatrix(int[, ] matrix)
{
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        int temp;
        for (int i = 0; i < matrix.GetLength(1) - 1; i++)
        {
            for (int j = i + 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[k, i] > matrix[k, j])
                {
                    temp = matrix[k, i];
                    matrix[k, i] = matrix[k, j];
                    matrix[k, j] = temp;
                }
            }
        } 
    }
    return matrix;
}

