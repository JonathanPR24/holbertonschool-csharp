using System;

/// <summary>
/// Provides methods for vector calculations.
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Multiplies a vector by a scalar and returns the resulting vector.
    /// </summary>
    /// <param name="vector">The vector (2D or 3D) to be multiplied.</param>
    /// <param name="scalar">The scalar value by which to multiply the vector.</param>
    /// <returns>The resulting vector or a vector containing -1 if the input vector is not 2D or 3D.</returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (!IsVectorValid(vector))
        {
            // Return a vector containing -1 if the input vector is not valid.
            return new double[] { -1 };
        }

        double[] result = new double[vector.Length];

        for (int i = 0; i < vector.Length; i++)
        {
            result[i] = vector[i] * scalar;
        }

        return result;
    }

    // Helper method to check if a vector is 2D or 3D
    private static bool IsVectorValid(double[] vector)
    {
        return vector.Length == 2 || vector.Length == 3;
    }
}
