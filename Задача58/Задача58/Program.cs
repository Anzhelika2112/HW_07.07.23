// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.


Console.Clear(); 

int[,] array1 = GetArray(4, 4, 1, 10);
int[,] array2 = GetArray(4, 4, 10, 20);

PrintArray(array1);
Console.WriteLine("---");
PrintArray(array2);

int[,] prod = ProdArray(array1, array2);
Console.WriteLine("Результирующая матрица: ");
PrintProdArray(prod); 


int[,] GetArray(int rows, int columns, int min, int max)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(min, max); 
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] ProdArray(int[,] array1, int[,] array2)
{
    int[,] prod = new int[array1.GetLength(0), array1.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            prod[i, j] = array1[i, j] * array2[i, j];
        }
    }
    return prod;
}

void PrintProdArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}