using System;

///<summary>Defines vector calculation methods.</summary>
class VectorMath
{
    ///<summary>Calculates and returns the length of a given vector.</summary>
    ///<param name="vector">The vector (2D or 3D) for which to calculate the magnitude.</param>
    ///<returns>The length of the vector rounded to the nearest hundredth.</returns>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length != 2 && vector.Length != 3)
            return -1;

        double squaredSum = vector.Sum(number => Math.Pow(number, 2));

        return Math.Round(Math.Sqrt(squaredSum), 2);
    }
}