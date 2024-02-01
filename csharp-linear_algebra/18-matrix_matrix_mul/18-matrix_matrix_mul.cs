using System;

/// <summary>
/// Provides methods for matrix calculations.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Multiplies two matrices and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix1">The first matrix.</param>
    /// <param name="matrix2">The second matrix.</param>
    /// <returns>The resulting matrix or a matrix containing -1 if the matrices cannot be multiplied.</returns>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        // Check if matrices can be multiplied
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
        {
            // Return a matrix containing -1 if matrices cannot be multiplied
            return new double[,] { { -1 } };
        }

        int rows1 = matrix1.GetLength(0);
        int columns1 = matrix1.GetLength(1);
        int columns2 = matrix2.GetLength(1);

        double[,] result = new double[rows1, columns2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < columns2; j++)
            {
                for (int k = 0; k < columns1; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return result;
    }
}
