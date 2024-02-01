using System;

/// <summary>
/// Provides methods for matrix calculations.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Shears a square 2D matrix by a given shear factor in the X or Y direction.
    /// </summary>
    /// <param name="matrix">The square 2D matrix to be sheared.</param>
    /// <param name="direction">The direction of the shear (either 'x' or 'y').</param>
    /// <param name="factor">The shear factor.</param>
    /// <returns>The resulting sheared matrix or a matrix containing -1 if the matrix is of an invalid size or an invalid direction is given.</returns>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Check if the matrix is square
        if (rows != cols)
        {
            return new double[,] { { -1 } };
        }

        double[,] shearedMatrix = new double[rows, cols];

        if (direction == 'x')
        {
            // Shear in the X direction
            for (int i = 0; i < rows; i++)
            {
                shearedMatrix[i, 0] = matrix[i, 0] + factor * matrix[i, 1];
                shearedMatrix[i, 1] = matrix[i, 1];
            }
        }
        else if (direction == 'y')
        {
            // Shear in the Y direction
            for (int i = 0; i < rows; i++)
            {
                shearedMatrix[i, 0] = matrix[i, 0];
                shearedMatrix[i, 1] = matrix[i, 0] * factor + matrix[i, 1];
            }
        }
        else
        {
            // Invalid direction
            return new double[,] { { -1 } };
        }

        return shearedMatrix;
    }
}
