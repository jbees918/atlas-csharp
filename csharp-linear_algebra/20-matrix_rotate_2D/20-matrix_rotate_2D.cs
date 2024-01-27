using System;

/// <summary>
/// Class to perform mathematical operations on matrices.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Rotates a square 2D matrix by a given angle in radians and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix">The matrix.</param>
    /// <param name="angle">The angle in radians.</param>
    /// <returns>The resulting matrix after rotation, or a matrix containing -1 if the matrix is not square.</returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix == null || matrix.GetLength(0) != matrix.GetLength(1))
        {
            return new double[,] { { -1 } };
        }

        int size = matrix.GetLength(0);
        double[,] result = new double[size, size];
        double cosAngle = Math.Cos(angle);
        double sinAngle = Math.Sin(angle);

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                // Apply rotation transformation
                result[i, j] = matrix[i, j] * cosAngle - matrix[j, i] * sinAngle;
            }
        }

        return result;
    }
}
