using System;

/// <summary>
/// Class to perform mathematical operations on vectors.
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Calculates magnitude of a given vector.
    /// </summary>
    /// <param name="vector">Vector whose magnitude needs to be calculated.</param>
    /// <returns>The magnitude of the vector, or -1 if the vector is not 2D or 3D.</returns>
    public static double Magnitude(double[] vector)
    {
        if (vector == null || (vector.Length != 2 && vector.Length != 3))
        {
            return -1;
        }

        double sumOfSquares = 0;
        foreach (var component in vector)
        {
            sumOfSquares += component * component;
        }

        double magnitude = Math.Sqrt(sumOfSquares);
        return Math.Round(magnitude, 2);
    }
}
