using System;
namespace homeworh3{
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter '+' or '-' to perform matrix operations, or any other character to exit:");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (input == '+' || input == '-')
            {
                Console.Write("Enter the size of the matrix (rows): ");
                int rows = int.Parse(Console.ReadLine());
                Console.Write("Enter the size of the matrix (columns): ");
                int columns = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the elements of the matrix:");

                double[,] matrixA = new double[rows, columns];
                double[,] matrixB = new double[rows, columns];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write($"[{i},{j}] of Matrix A: ");
                        matrixA[i, j] = double.Parse(Console.ReadLine());
                    }
                }

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write($"[{i},{j}] of Matrix B: ");
                        matrixB[i, j] = double.Parse(Console.ReadLine());
                    }
                }

                if (input == '+')
                {
                    double[,] sumMatrix = AddMatrices(matrixA, matrixB, rows, columns);
                    Console.WriteLine("The sum of the matrices is:");
                    PrintMatrix(sumMatrix, rows, columns);
                }
                else if (input == '-')
                {
                    double[,] differenceMatrix = SubtractMatrices(matrixA, matrixB, rows, columns);
                    Console.WriteLine("The difference of the matrices is:");
                    PrintMatrix(differenceMatrix, rows, columns);
                }
            }
            else
            {
                break;
            }

            Console.WriteLine();
        }
    }

    static double[,] AddMatrices(double[,] matrixA, double[,] matrixB, int rows, int columns)
    {
        double[,] resultMatrix = new double[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                resultMatrix[i, j] = matrixA[i, j] + matrixB[i, j];
            }
        }

        return resultMatrix;
    }

    static double[,] SubtractMatrices(double[,] matrixA, double[,] matrixB, int rows, int columns)
    {
        double[,] resultMatrix = new double[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                resultMatrix[i, j] = matrixA[i, j] - matrixB[i, j];
            }
        }

        return resultMatrix;
    }

    static void PrintMatrix(double[,] matrix, int rows, int columns)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
}