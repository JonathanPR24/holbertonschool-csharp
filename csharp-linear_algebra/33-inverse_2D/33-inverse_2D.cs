using System;

class MatrixMath
{
    /// <summary>
    /// Calculates the inverse of a 2D matrix.
    /// </summary>
    /// <param name="matrix">The 2D matrix to invert.</param>
    /// <returns>The resulting inverted matrix, or a matrix containing -1 if the input matrix is not 2D or non-invertible.</returns>
    public static double[,] Inverse2D(double[,] matrix)
    {
        // Check if the matrix is 2D
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            // Return a matrix containing -1 if the input matrix is not 2D
            return new double[,] { { -1 } };
        }

        // Calculate determinant
        double determinant = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];

        // Check if the matrix is non-invertible
        if (Math.Abs(determinant) < double.Epsilon)
        {
            // Return a matrix containing -1 if the matrix is non-invertible
            return new double[,] { { -1 } };
        }

        // Calculate inverse
        double[,] inverseMatrix = new double[2, 2];
        inverseMatrix[0, 0] = matrix[1, 1] / determinant;
        inverseMatrix[0, 1] = -matrix[0, 1] / determinant;
        inverseMatrix[1, 0] = -matrix[1, 0] / determinant;
        inverseMatrix[1, 1] = matrix[0, 0] / determinant;

        return inverseMatrix;
    }
}
