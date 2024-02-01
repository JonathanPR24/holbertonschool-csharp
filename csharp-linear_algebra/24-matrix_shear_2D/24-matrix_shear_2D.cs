using System;

class MatrixMath
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
        // Identity shear matrix
        double[,] shearMat = { { 1, 0 }, { 0, 1 } };
        double[,] shearedMat = new double[2, 2];
        int numLines = matrix.GetLength(0);

        // Check for valid direction
        if (direction != 'x' && direction != 'y')
            return new double[,] { { -1 } };

        // Check for valid matrix size
        if (matrix.Length != 4 || matrix.GetLength(0) != 2)
            return new double[,] { { -1 } };

        // Update shear matrix based on direction and factor
        if (direction == 'x')
            shearMat[0, 1] = factor;
        else
            shearMat[1, 0] = factor;

        // Apply shear transformation to each row of the matrix
        for (int i = 0; i < numLines; i++)
        {
            shearedMat[i, 0] = shearMat[0, 0] * matrix[i, 0] + shearMat[0, 1] * matrix[i, 1];
            shearedMat[i, 1] = shearMat[1, 0] * matrix[i, 0] + shearMat[1, 1] * matrix[i, 1];
        }

        return shearedMat;
    }
}
