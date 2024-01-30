using System;

/// <summary>
/// Provides methods for vector calculations.
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Calculates the dot product of either two 2D or two 3D vectors.
    /// </summary>
    /// <param name="vector1">The first vector (2D or 3D).</param>
    /// <param name="vector2">The second vector (2D or 3D).</param>
    /// <returns>The dot product of the two vectors or -1 if the vectors are not of the same size or are not either both 2D or both 3D.</returns>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (!IsVectorValid(vector1) || !IsVectorValid(vector2) || vector1.Length != vector2.Length)
        {
            // Return -1 if vectors are not valid or not of the same size.
            return -1;
        }

        double result = 0;

        for (int i = 0; i < vector1.Length; i++)
        {
            result += vector1[i] * vector2[i];
        }

        return result;
    }

    // Helper method to check if a vector is 2D or 3D
    private static bool IsVectorValid(double[] vector)
    {
        return vector.Length == 2 || vector.Length == 3;
    }
}
