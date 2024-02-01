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
        // Check if the matrix is square and has a size of 2x2
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            // Return a matrix containing -1 if the matrix is of an invalid size
            return new double[,] { { -1 } };
        }

        double[,] result = new double[2, 2];

        // Rotation matrix for 2D rotation
        double[,] rotationMatrix = {
            { Math.Cos(angle), -Math.Sin(angle) },
            { Math.Sin(angle), Math.Cos(angle) }
        };

        // Multiply the original matrix by the rotation matrix
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    result[i, j] += matrix[i, k] * rotationMatrix[k, j];
                }
            }
        }

        return result;
    }
}
