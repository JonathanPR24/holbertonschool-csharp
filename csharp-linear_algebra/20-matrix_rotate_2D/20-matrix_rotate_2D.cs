using System;

/// <summary>
/// Provides methods for matrix calculations.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Rotates a square 2D matrix by a given angle in radians.
    /// </summary>
    /// <param name="matrix">The square 2D matrix.</param>
    /// <param name="angle">The angle in radians by which to rotate the matrix.</param>
    /// <returns>The resulting rotated matrix or a matrix containing -1 if the matrix is of an invalid size.</returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Check if the matrix is square and has a valid size (2x2)
        if (rows != 2 || cols != 2)
        {
            return new double[,] { { -1 } };
        }

        double[,] rotatedMatrix = new double[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            double x = matrix[i, 0];
            double y = matrix[i, 1];

            rotatedMatrix[i, 0] = Math.Round(x * Math.Cos(angle) - y * Math.Sin(angle), 2);
            rotatedMatrix[i, 1] = Math.Round(x * Math.Sin(angle) + y * Math.Cos(angle), 2);
        }

        return rotatedMatrix;
    }
}
