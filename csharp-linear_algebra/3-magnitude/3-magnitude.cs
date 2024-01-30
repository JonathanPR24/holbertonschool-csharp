using System;

public class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        // Check if the vector is 2D or 3D
        if (vector.Length != 2 && vector.Length != 3)
        {
            // If not, return -1 indicating an invalid vector
            return -1;
        }

        // Calculate the magnitude using the Pythagorean theorem for 2D or 3D vectors
        double magnitudeSquared = 0;
        foreach (double component in vector)
        {
            magnitudeSquared += Math.Pow(component, 2);
        }

        // Calculate square root and round to the nearest hundredth
        double magnitude = Math.Round(Math.Sqrt(magnitudeSquared), 2);

        return magnitude;
    }

}
