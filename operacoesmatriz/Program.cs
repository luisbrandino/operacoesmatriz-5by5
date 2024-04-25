int rows = 3;
int columns = 3;

double[,] matrixA = new double[rows, columns];
double[,] matrixB = new double[rows, columns];
double[,] result = new double[rows, columns];
void randomizeMatrix(double[,] matrix, int min = 0, int max = 10)
{
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            matrix[i, j] = new Random().Next(min, max);
}

void printMatrix(double[,] matrix)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            Console.Write($"{matrix[i, j].ToString("0.0")} ");

        Console.WriteLine();
    }
}

double calculate(char operation, double a, double b)
{
    switch (operation)
    {
        case '+':
            return a + b;
        case '-':
            return a - b;
        case '*':
            return a * b;
        default:
            if (b == 0)
                return double.NaN;
            return a / b;
    }
}
char selectOperatorMenu()
{
    Console.Write("Informe a operação que deseja executar nas matrizes (+, -, *, /): ");
    char operation = Console.ReadLine().First();

    while (true)
    {
        bool correctOperator =
            operation == '+' ||
            operation == '-' ||
            operation == '*' ||
            operation == '/';

        if (correctOperator)
            break;

        Console.Write("Operador inválido, tente novamente (+, -, *, /): ");
        operation = Console.ReadLine().First();
    }

    return operation;
}

randomizeMatrix(matrixA);
randomizeMatrix(matrixB);

Console.WriteLine("Matriz A:\n");

printMatrix(matrixA);

Console.WriteLine("\nMatriz B:\n");

printMatrix(matrixB);

Console.WriteLine();

char operation = selectOperatorMenu();

Console.WriteLine($"\nResultado ({operation}):");

for (int i = 0; i < rows; i++)
    for (int j = 0; j < rows; j++)
        result[i, j] = calculate(operation, matrixA[i, j], matrixB[i, j]);

printMatrix(result);