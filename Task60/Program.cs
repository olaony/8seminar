﻿// // Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая 
// будет построчно 
// выводить массив, добавляя индексы каждого элемента.

Console.WriteLine("Введите длину массива: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ширину массива: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите высоту массива: ");
int z = Convert.ToInt32(Console.ReadLine());
int[,,] matrix = new int[x, y, z]; 
int n = 10;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(2); k++)
        {
            matrix[i, j, k] = n;
            Console.WriteLine($"{matrix[i, j, k]} ({i}, {j}, {k})");
            n++;

        }
        }
}