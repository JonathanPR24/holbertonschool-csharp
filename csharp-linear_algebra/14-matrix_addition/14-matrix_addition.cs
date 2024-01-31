using System;

/// <summary>
/// Provides methods for matrix calculations.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Adds two matrices and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix1">The first matrix (2D or 3D).</param>
    /// <param name="matrix2">The second matrix (2D or 3D).</param>
    /// <returns>The resulting matrix or a matrix containing -1 if the matrices are not of the same size or are not either both 2D or both 3D.</returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        if (!IsMatrixValid(matrix1) || !IsMatrixValid(matrix2) || !AreMatricesSameSize(matrix1, matrix2))
        {
            // Return a matrix containing -1 if matrices are not valid or not of the same size.
            return new double[,] { { -1 } };
        }

        int rows = matrix1.GetLength(0);
        int columns = matrix1.GetLength(1);

        double[,] result = new double[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return result;
    }

    // Helper method to check if a matrix is 2D or 3D
    private static bool IsMatrixValid(double[,] matrix)
    {
        return matrix.Rank == 2 && (matrix.GetLength(0) == 2 || matrix.GetLength(0) == 3) && matrix.GetLength(0) == matrix.GetLength(1);
    }

    // Helper method to check if two matrices are of the same size
    private static bool AreMatricesSameSize(double[,] matrix1, double[,] matrix2)
    {
        return matrix1.GetLength(0) == matrix2.GetLength(0) && matrix1.GetLength(1) == matrix2.GetLength(1);
    }
}
