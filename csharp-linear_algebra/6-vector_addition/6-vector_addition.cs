using System;

/// <summary>
/// Class to perform mathematical operations on vectors.
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Adds two vectors and returns the resulting vector.
    /// </summary>
    /// <param name="vector1">The first vector.</param>
    /// <param name="vector2">The second vector.</param>
    /// <returns>The resulting vector after addition, or a vector containing -1 if the vectors are not of the same size or if any vector is not 2D or 3D.</returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1 == null || vector2 == null || (vector1.Length != 2 && vector1.Length != 3) || (vector2.Length != 2 && vector2.Length != 3) || vector1.Length != vector2.Length)
        {
            return new double[] { -1 };
        }

        double[] result = new double[vector1.Length];
        for (int i = 0; i < vector1.Length; i++)
        {
            result[i] = vector1[i] + vector2[i];
        }

        return result;
    }
}
