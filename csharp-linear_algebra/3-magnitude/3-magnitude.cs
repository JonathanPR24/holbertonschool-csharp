using System;

/// <summary>
/// Provides methods for vector calculations.
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Calculates and returns the length of a given vector.
    /// </summary>
    /// <param name="vector">The vector (2D or 3D) for which to calculate the magnitude.</param>
    /// <returns>The length of the vector rounded to the nearest hundredth, or -1 if the vector is not 2D or 3D.</returns>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length != 2 && vector.Length != 3)
        {
            return -1;
        }

        double squaredSum = 0;

        foreach (double number in vector)
        {
            squaredSum += Math.Pow(number, 2);
        }

        return Math.Round(Math.Sqrt(squaredSum), 2);
    }

}