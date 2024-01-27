using System;

/// <summary>
/// Class to perform mathematical operations on vectors.
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Multiplies a vector and a scalar and returns the resulting vector.
    /// </summary>
    /// <param name="vector">The vector.</param>
    /// <param name="scalar">The scalar.</param>
    /// <returns>Resulting vector after multiplication, or a vector containing -1 if the vector is not 2D or 3D.</returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector == null || (vector.Length != 2 && vector.Length != 3))
        {
            return new double[] { -1 };
        }

        double[] result = new double[vector.Length];
        for (int i = 0; i < vector.Length; i++)
        {
            result[i] = vector[i] * scalar;
        }

        return result;
    }
}
