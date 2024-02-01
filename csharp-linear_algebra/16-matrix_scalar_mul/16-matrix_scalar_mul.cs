using System;

///<summary>Defines matrix calculation methods.</summary>
class MatrixMath
{
    ///<summary>Multiplies a matrix and a scalar.</summary>
    ///<param name="matrix">The matrix.</param>
    ///<param name="scalar">The scalar.</param>
    ///<returns>The resulting matrix.</returns>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        // Checks if matrix is a square matrix
        if (matrix.Length != 4 && matrix.Length != 9)
            return new double[,] { { -1 } };

        // Checks if matrix is 2D or 3D
        if ((matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2) && (matrix.GetLength(0) != 3 || matrix.GetLength(1) != 3))
            return new double[,] { { -1 } };

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] *= scalar;
            }
        }

        return matrix;
    }
}
