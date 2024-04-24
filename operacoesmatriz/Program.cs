int rows = 3;
int columns = 3;

double[,] matrixA = new double[rows, columns];
double[,] matrixB = new double[rows, columns];
double[,] result = new double[rows, columns];

for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
    {
        matrixA[i, j] = new Random().Next(0, 10);
        matrixB[i, j] = new Random().Next(0, 10);
    }

Console.WriteLine("Matriz A:\n");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
        Console.Write($"{matrixA[i, j]} ");

    Console.WriteLine();
}

Console.WriteLine("\nMatriz B:\n");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
        Console.Write($"{matrixB[i, j]} ");

    Console.WriteLine();
}

for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
        result[i, j] = matrixA[i, j] + matrixB[i, j];

Console.WriteLine("\nSoma:\n");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
        Console.Write($"{result[i, j]} ");

    Console.WriteLine();
}

for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
        result[i, j] = matrixA[i, j] - matrixB[i, j];

Console.WriteLine("\nSubtração:\n");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
        Console.Write($"{result[i, j]} ");

    Console.WriteLine();
}

for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
        result[i, j] = matrixA[i, j] * matrixB[i, j];

Console.WriteLine("\nMultiplicação:\n");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
        Console.Write($"{result[i, j]} ");

    Console.WriteLine();
}

for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
    {
        if (matrixB[i, j] == 0)
        {
            result[i, j] = 0;
            continue;
        }

        result[i, j] = matrixA[i, j] / matrixB[i, j];
    }

Console.WriteLine("\nDivisão:\n");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
        Console.Write($"{result[i, j].ToString("0.0")} ");

    Console.WriteLine();
}