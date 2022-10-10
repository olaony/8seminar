// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет 
// находить строку с наименьшей суммой элементов.

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


void ReleaseMatrix(int[, ] matrix)
{
    int summ = 0;
    int index = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            temp += matrix[i, j];
        }
        if (temp > summ)
        {
            summ = temp;
            index = 1;
        }
    }
    Console.WriteLine("Строка: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine(matrix[index, i]);
    }
}

Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[, ] matrix = new int[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);
ReleaseMatrix(matrix);