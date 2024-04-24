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

void printMatrix(double[,] matrix )
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            Console.Write($"{matrix[i, j].ToString("0.0")} ");

        Console.WriteLine();
    }
}

Console.WriteLine("Matriz A:\n");

printMatrix(matrixA);

Console.WriteLine("\nMatriz B:\n");

printMatrix(matrixB);

for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
        result[i, j] = matrixA[i, j] + matrixB[i, j];

Console.WriteLine("\nSoma:\n");

printMatrix(result);

for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
        result[i, j] = matrixA[i, j] - matrixB[i, j];

Console.WriteLine("\nSubtração:\n");

printMatrix(result);

for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
        result[i, j] = matrixA[i, j] * matrixB[i, j];

Console.WriteLine("\nMultiplicação:\n");

printMatrix(result);

for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
    {
        if (matrixB[i, j] == 0)
        {
            result[i, j] = double.NaN;
            continue;
        }

        result[i, j] = matrixA[i, j] / matrixB[i, j];
    }

Console.WriteLine("\nDivisão:\n");

printMatrix(result);