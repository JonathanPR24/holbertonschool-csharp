using System;

/// <summary>
/// Provides methods for vector calculations.
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Adds two vectors and returns the resulting vector.
    /// </summary>
    /// <param name="vector1">The first vector (2D or 3D).</param>
    /// <param name="vector2">The second vector (2D or 3D).</param>
    /// <returns>The resulting vector or a vector containing -1 if the vectors are not 2D or 3D or if they are not of the same size.</returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (!IsVectorValid(vector1) || !IsVectorValid(vector2) || vector1.Length != vector2.Length)
        {
            // Return a vector containing -1 if vectors are not valid or not of the same size.
            return new double[] { -1 };
        }

        double[] result = new double[vector1.Length];
        
        for (int i = 0; i < vector1.Length; i++)
        {
            result[i] = vector1[i] + vector2[i];
        }

        return result;
    }

    // Helper method to check if a vector is 2D or 3D
    private static bool IsVectorValid(double[] vector)
    {
        return vector.Length == 2 || vector.Length == 3;
    }
}
