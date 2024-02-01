using System;

class MatrixMath
{
    /// <summary>
    /// Calculates the determinant of a 2x2 or 3x3 matrix.
    /// </summary>
    /// <param name="matrix">The matrix to calculate the determinant for.</param>
    /// <returns>The determinant rounded to the nearest hundredth, or -1 if the matrix is invalid.</returns>
    public static double Determinant(double[,] matrix)
    {
        if (matrix.Length != 4 && matrix.Length != 9)
            return -1;

        // Checks if matrix is 2D or 3D
        if ((matrix.GetLength(0) != 2 && matrix.GetLength(0) != 3) || (matrix.GetLength(1) != 2 && matrix.GetLength(1) != 3))
            return -1;

        if (matrix.Length == 4)
        {
            return Math.Round(matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0], 2);
        }
        else if (matrix.Length == 9)
        {
            return Math.Round(matrix[0, 0] * matrix[1, 1] * matrix[2, 2] +
               matrix[0, 1] * matrix[1, 2] * matrix[2, 0] +
               matrix[0, 2] * matrix[1, 0] * matrix[2, 1] -
               matrix[0, 2] * matrix[1, 1] * matrix[2, 0] -
               matrix[0, 1] * matrix[1, 0] * matrix[2, 2] -
               matrix[0, 0] * matrix[1, 2] * matrix[2, 1], 2);
        }

        // Unreachable code, but added for completeness
        return -1;
    }
}
