using System;

/// <summary>
/// Provides methods for matrix calculations.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Transposes a matrix.
    /// </summary>
    /// <param name="matrix">The matrix to be transposed.</param>
    /// <returns>The resulting transposed matrix or an empty matrix if the input matrix is empty.</returns>
    public static double[,] Transpose(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Check if the matrix is empty
        if (rows == 0 || cols == 0)
            return new double[,] { };

        double[,] transposedMatrix = new double[cols, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transposedMatrix[j, i] = matrix[i, j];
            }
        }

        return transposedMatrix;
    }
}
