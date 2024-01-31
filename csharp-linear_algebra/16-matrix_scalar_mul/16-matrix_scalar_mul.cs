using System;

/// <summary>
/// Provides methods for matrix calculations.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Multiplies a matrix by a scalar and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix">The matrix (2D or 3D) to be multiplied.</param>
    /// <param name="scalar">The scalar value by which to multiply the matrix.</param>
    /// <returns>The resulting matrix or a matrix containing -1 if the input matrix is not 2D or 3D.</returns>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if (!IsMatrixValid(matrix))
        {
            // Return a matrix containing -1 if the input matrix is not valid.
            return new double[,] { { -1 } };
        }

        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        double[,] result = new double[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = matrix[i, j] * scalar;
            }
        }

        return result;
    }

    // Helper method to check if a matrix is 2D or 3D
    private static bool IsMatrixValid(double[,] matrix)
    {
        return matrix.Rank == 2 && (matrix.GetLength(0) == 2 || matrix.GetLength(0) == 3);
    }
}
